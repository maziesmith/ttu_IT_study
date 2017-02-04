using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olümpiaad {
    class GridPosition {
        public ulong X { get; set; } = 0;
        public ulong Y { get; set; } = 0;
     }

    class Program {
        static string currentExePath = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
        static string targetPath = Directory.GetParent(currentExePath).FullName;
        static string projectPath = Directory.GetParent(targetPath).FullName;

        static readonly string fileName = "joonsis.txt";
        static readonly string outputFileName = "joonval.txt";

        static void Main(string[] args) {
            int stepValue = GetJoonisPathStep();
            GridPosition position = GetGridStepPosition(stepValue);

            WriteValueFile(position);
        }

        public static GridPosition GetGridStepPosition(int step) {
            ulong x = 1;
            ulong y = 1;

            ulong cycle = 1;
            ulong cycleCount = 0;

            ulong[] upperCollection = { 1, 3, 5 };
            ulong[] rightCollection = { 2, 4, 6 };

            for (int i = 0; i < step; i++) {
                if (cycle == 1) {
                    x++;
                    cycle++;
                } else if (cycle == 2) {
                    if (y < (1 + (cycleCount * 2) + 1)) {
                        y++;
                    } else {
                        cycle++;

                        if (x > 1) {
                            x--;
                        }
                    }
                } else if (cycle == 3) {
                    if (x > 1) {
                        x--;
                    } else {
                        cycle++;
                        y++; // Cycle 4 actually
                    }
                } else if (cycle == 4) {
                    if (x < (2 + (cycleCount * 2) + 1)) {
                        x++;
                    } else {
                        cycle++;

                        if (y > 1) {
                            y--;
                        }
                    }
                } else if (cycle == 5) {
                    if (y > 1) {
                        y--;
                    } else {
                        cycle = 2;
                        cycleCount++;
                        x++;
                    }
                }
            }

            return new GridPosition {
                X = x,
                Y = y
            };
        }

        static int GetJoonisPathStep () {
            string textFilePath = Path.Combine(projectPath, fileName);
            
            try {
                string fileText = File.ReadAllText(textFilePath).Trim();
                return Convert.ToInt32(fileText);
            } catch (Exception e) {
                throw e;
            }
        }

        static void WriteValueFile (GridPosition position) {
            string filePath = Path.Combine(projectPath, outputFileName);

            try {
                using (FileStream fs = File.OpenWrite(filePath)) {
                    Byte[] gridPosition = new UTF8Encoding(true).GetBytes(string.Format("{0} {1}", position.X, position.Y));

                    fs.Write(gridPosition, 0, gridPosition.Length);
                }
            } catch (Exception e) {
                throw e;
            }
        }
    }
}
