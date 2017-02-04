using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAndSwitch {
    class Program {
        static void Main(string[] args) {
            List<Todo> todos = new List<Todo>() {
                new Todo { Description = "Task #1", EstimatedHours = 15, Status= Status.InProgress },
                new Todo { Description = "Task #2", EstimatedHours = 6, Status= Status.Competed },
                new Todo { Description = "Task #3", EstimatedHours = 13, Status= Status.InProgress },
                new Todo { Description = "Task #4", EstimatedHours = 2, Status= Status.Deleted },
                new Todo { Description = "Task #5", EstimatedHours = 135, Status= Status.InProgress },
                new Todo { Description = "Task #6", EstimatedHours = 7, Status= Status.NotStarted },
                new Todo { Description = "Task #7", EstimatedHours = 42, Status= Status.InProgress },
                new Todo { Description = "Task #8", EstimatedHours = 13, Status= Status.NotStarted },
                new Todo { Description = "Task #9", EstimatedHours = 6, Status= Status.Deleted },
                new Todo { Description = "Task #10", EstimatedHours = 6, Status= Status.InProgress },
                new Todo { Description = "Task #1", EstimatedHours = 65, Status= Status.InProgress },
                new Todo { Description = "Task #11", EstimatedHours = 1, Status= Status.NotStarted },
                new Todo { Description = "Task #12", EstimatedHours = 2, Status= Status.InProgress },
                new Todo { Description = "Task #13", EstimatedHours = 4, Status= Status.Deleted },
                new Todo { Description = "Task #14", EstimatedHours = 3, Status= Status.NotStarted }
            };

            Console.WriteLine("TODOS:");

            try {
                PrintTodos(todos);
            } catch (Exception e) {
                Console.BackgroundColor = ConsoleColor.Red;

                Console.WriteLine("Error");
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }

        private static void PrintTodos (List<Todo> todos) {
            foreach (var todo in todos) {
                switch (todo.Status) {
                    case Status.NotStarted:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        break;

                    case Status.Competed:
                        Console.BackgroundColor = ConsoleColor.Green;
                        break;

                    case Status.Deleted:
                        Console.BackgroundColor = ConsoleColor.Red;
                        break;

                    case Status.OnHold:
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        break;

                    case Status.InProgress:
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                }

                Console.WriteLine("{0} ({1}h)", todo.Description, todo.EstimatedHours);
            }
        }
    }

    class Todo {
        public string Description { get; set; }
        public int EstimatedHours { get; set; }
        public Status Status { get; set; }

    }

    enum Status {
        NotStarted,
        InProgress,
        OnHold,
        Competed,
        Deleted
    }
}
