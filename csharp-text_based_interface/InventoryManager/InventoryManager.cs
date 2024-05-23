using System;
using System.IO;
using System.Collections.Generic;
using InventoryLibrary;
using System.Linq;

namespace InventoryManager
{
    public class Program
    {
        static void Main(string[] args)
        {
            storage.Load();
            Initialize();

            while (true)
            {
                Console.Write("**Hello, please enter a command** ");
                string input = Console.ReadLine().ToLower();
                if (ProcessCommand(input))
                {
                    WelcomePrompt();
                }
            }
            
        public static void Initialize()
        {
            methods = new Dictionary<string, method>()
            {
                {"classnames", ClassNames},
                {"all", All},
                {"create", Create},
                {"show", Show},
                {"update", Update},
                {"delete", Delete}
            };
        }

        public static bool ProcessCommand(string command, string[] args)
        {
            Delegate commandMethod;
            if (methods.TryGetValue(command, out commandMethod))
            {
                return method(args);
            }
            else
            {
                return false;
            }
        }

        public static void WelcomePrompt()
        {
            Console.WriteLine("Inventory Manager");
            Console.WriteLine("-------------------------");
            Console.WriteLine("<ClassNames> show all ClassNames of objects");
            Console.WriteLine("<All> show all objects");
            Console.WriteLine("<All [ClassName]> show all objects of a ClassName");
            Console.WriteLine("<Create [ClassName]> a new object");
            Console.WriteLine("<Show [ClassName object_id]> an object");
            Console.WriteLine("<Update [ClassName object_id]> an object");
            Console.WriteLine("<Delete [ClassName object_id]> an object");
            Console.WriteLine("<Exit>");
        }

        public static bool ClassNames(string[] args)
        {
            foreach (var className in storage.GetClassNames())
            {
                Console.WriteLine(className);
            }
            return true;
        }

        public static bool All(string[] args)
        {
            if (args.Length == 1)
            {
                var className = args[0];

                if (storage.GetClassNames().Contains(className))
                {
                    var newObj = storage.CreateObject(className);
                    storage.SaveObject(newObj);
                    Console.WriteLine($"Created new {className} object with ID {newObj.Id}");
                }
                else
                {
                    Console.WriteLine($"{className} is not a valid object type");
                }
            }

            return true;
        }

        public static bool Create(string[] args)
        {
            if (args.Length == 1)
            {
                var className = args[0];

                if (storage.GetClassNames().Contains(className))
                {
                    var newObj = storage.CreateObject(className);
                    storage.SaveObject(newObj);
                    Console.WriteLine($"Created new {className} object with ID {newObj.Id}");
                }
                else
                {
                    Console.WriteLine($"{className} is not a valid object type");
                }
            }

            return true;
        }

        public static bool Show(string[] args)
        {
            if (args.Length == 2)
            {
                var className = args[0];
                var id = args[1];

                if (storage.GetClassNames().Contains(className))
                {
                    var obj = storage.GetObject(className, id);
                    if (obj != null)
                    {
                        Console.WriteLine(obj.ToString());
                    }
                    else
                    {
                        Console.WriteLine($"Object {id} could not be found");
                    }
                }
                else
                {
                    Console.WriteLine($"{className} is not a valid object type");
                }
            }

            return true;
        }

        public static bool Update(string[] args)
        {
            var obj = storage.GetObject(className, id);

            if (obj != null)
            {
                var obj = storage.GetObject(className, id);

                if (obj != null)
                {
                    storage.SaveObject(obj);
                    Console.WriteLine($"Updated {className} object with ID {obj.Id}");
                }
                else
                {
                    Console.WriteLine($"Object {id} could not be found");
                }
            }

            return true;
        }

        public static bool Delete(string[] args)
        {
            if (args.Length == 2)
            {
                var className = args[0];
                var id = args[1];

                if (storage.GetClassNames().Contains(className))
                {
                    var obj = storage.GetObject(className, id);
                    if (obj != null)
                    {
                        storage.DeleteObject(obj);
                        Console.WriteLine($"Deleted {className} object with ID {obj.Id}");
                    }
                    else
                    {
                        Console.WriteLine($"Object {id} could not be found");
                    }
                }
                else
                {
                    Console.WriteLine($"{className} is not a valid object type");
                }
            }

            return true;
        }
    }
}