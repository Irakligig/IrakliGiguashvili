
using System.Reflection;
namespace practicalReflection
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Type calculatorType = typeof(Calculator); // puts calculator type

            MethodInfo[] methodinfos = calculatorType.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            // gets every method(with its metadata) and puts it into array 

            foreach (MethodInfo method in methodinfos)
            {
                Console.WriteLine(method.Name);
                foreach (ParameterInfo param in method.GetParameters())
                {
                    Console.WriteLine($"Parameter : {param.Name} , TypeOfParameter : {param.ParameterType}");
                }
            }



            // ----------------------------------------------------
            object instance = Activator.CreateInstance(calculatorType);
            // dynamically creating an instance of an object with only type.


            MethodInfo addMethod = calculatorType.GetMethod("Add"); // konkretuli methodis infostvis
            MethodInfo subsMethod = calculatorType.GetMethod("Substract");
            MethodInfo MultMethod = calculatorType.GetMethod("Mult");
            MethodInfo DivMethod = calculatorType.GetMethod("Div");

            Console.WriteLine("Enter which function you want to use: ");
            string function = Console.ReadLine();

            MethodInfo selectedMethod;
            switch (function)
            {
                case "Add":
                    selectedMethod = addMethod;
                    break;
                case "Substract":
                    selectedMethod = subsMethod;
                    break;
                case "Mult":
                    selectedMethod = MultMethod;
                    break;
                case "Div":
                    selectedMethod = DivMethod;
                    break;
                default:
                    Console.WriteLine("Invalid function. Exiting...");
                    return;
            }


            ParameterInfo[] parameters = selectedMethod.GetParameters(); // sul ertia , mainc ori parametriaq erti da igive
            object[] InputParameters = new object[parameters.Length];
            for (int i = 0; i < InputParameters.Length; i++)
            {
                bool validInput = false;

                while (!validInput)
                {
                    Console.WriteLine($"enter parameter : {parameters[i]} with parameter type {parameters[i].ParameterType}");
                    string input = Console.ReadLine();
                    if (parameters[i].ParameterType == typeof(double))
                    {
                        if (double.TryParse(input, out double doubleresult))
                        {
                            InputParameters[i] = Convert.ChangeType(input, parameters[i].ParameterType);
                            validInput = true;
                        }
                        else
                        {
                            Console.WriteLine("Enter valid double value");
                        }
                    }
                    else
                    {
                        try
                        {
                            InputParameters[i] = Convert.ChangeType(input, parameters[i].ParameterType);
                            validInput = true;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error occured while inputing a parameter");
                        }
                    }
                }
            }

            try
            {
                object result = selectedMethod.Invoke(instance, InputParameters);
                Console.WriteLine($"Result : {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex}");
            }
        }
    }
}
