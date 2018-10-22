    #region 
using System;
using System.IO; // This is required for File I/O
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion

namespace ProgrammingAssignmentCSCI860M011155058
{
    /// <summary>
    /// Kinjal Jarodiya(1155058)
    /// Programming Assignment 1
    /// CSCI-860-M01 
    /// </summary>
    class Program
    {
        static void Main()
        {
            #region Static double arrays that represent the genuine Score vectors

            parseCSV parseCSV = new parseCSV();

            parseCSV.getValue(s002);
            parseCSV.getValue(s003);
            parseCSV.getValue(s004);
            parseCSV.getValue(s005);
            parseCSV.getValue(s007);
            parseCSV.getValue(s008);
            parseCSV.getValue(s010);
            parseCSV.getValue(s011);
            parseCSV.getValue(s012);
            parseCSV.getValue(s013);
            parseCSV.getValue(s015);
            parseCSV.getValue(s016);
            parseCSV.getValue(s017);
            parseCSV.getValue(s018);
            parseCSV.getValue(s019);
            parseCSV.getValue(s020);
            parseCSV.getValue(s021);
            parseCSV.getValue(s022);
            parseCSV.getValue(s024);
            parseCSV.getValue(s025);
            parseCSV.getValue(s026);
            parseCSV.getValue(s027);
            parseCSV.getValue(s028);
            parseCSV.getValue(s029);
            parseCSV.getValue(s030);
            parseCSV.getValue(s031);
            parseCSV.getValue(s032);
            parseCSV.getValue(s033);
            parseCSV.getValue(s034);
            parseCSV.getValue(s035);
            parseCSV.getValue(s036);
            parseCSV.getValue(s037);
            parseCSV.getValue(s038);
            parseCSV.getValue(s039);
            parseCSV.getValue(s040);
            parseCSV.getValue(s041);
            parseCSV.getValue(s042);
            parseCSV.getValue(s043);
            parseCSV.getValue(s044);
            parseCSV.getValue(s046);
            parseCSV.getValue(s047);
            parseCSV.getValue(s048);
            parseCSV.getValue(s049);
            parseCSV.getValue(s050);
            parseCSV.getValue(s051);
            parseCSV.getValue(s052);
            parseCSV.getValue(s053);
            parseCSV.getValue(s054);
            parseCSV.getValue(s055);
            parseCSV.getValue(s056);
            parseCSV.getValue(s057);
            #endregion

            string subjectNumber = Console.ReadLine();
            Console.Write("------------------------------------------------------------Answer A-------------------------------------------------------------" + Environment.NewLine);
            Console.Write("-------compute the template using mean key hold and key interval features calculated on the first N typing samples.--------------" + Environment.NewLine);
            Console.Write("................................................................................................................................." + Environment.NewLine);
            #region Static double arrays that represent the genuine Score vectors
            MeanVector.getValue(s002_Genuine);
            MeanVector.getValue(s003_Genuine);
            MeanVector.getValue(s004_Genuine);
            MeanVector.getValue(s005_Genuine);
            MeanVector.getValue(s007_Genuine);
            MeanVector.getValue(s008_Genuine);
            MeanVector.getValue(s010_Genuine);
            MeanVector.getValue(s011_Genuine);
            MeanVector.getValue(s012_Genuine);
            MeanVector.getValue(s013_Genuine);
            MeanVector.getValue(s015_Genuine);
            MeanVector.getValue(s016_Genuine);
            MeanVector.getValue(s017_Genuine);
            MeanVector.getValue(s018_Genuine);
            MeanVector.getValue(s019_Genuine);
            MeanVector.getValue(s020_Genuine);
            MeanVector.getValue(s021_Genuine);
            MeanVector.getValue(s022_Genuine);
            MeanVector.getValue(s024_Genuine);
            MeanVector.getValue(s025_Genuine);
            MeanVector.getValue(s026_Genuine);
            MeanVector.getValue(s027_Genuine);
            MeanVector.getValue(s028_Genuine);
            MeanVector.getValue(s029_Genuine);
            MeanVector.getValue(s030_Genuine);
            MeanVector.getValue(s031_Genuine);
            MeanVector.getValue(s032_Genuine);
            MeanVector.getValue(s033_Genuine);
            MeanVector.getValue(s034_Genuine);
            MeanVector.getValue(s035_Genuine);
            MeanVector.getValue(s036_Genuine);
            MeanVector.getValue(s037_Genuine);
            MeanVector.getValue(s038_Genuine);
            MeanVector.getValue(s039_Genuine);
            MeanVector.getValue(s040_Genuine);
            MeanVector.getValue(s041_Genuine);
            MeanVector.getValue(s042_Genuine);
            MeanVector.getValue(s043_Genuine);
            MeanVector.getValue(s044_Genuine);
            MeanVector.getValue(s046_Genuine);
            MeanVector.getValue(s047_Genuine);
            MeanVector.getValue(s048_Genuine);
            MeanVector.getValue(s049_Genuine);
            MeanVector.getValue(s050_Genuine);
            MeanVector.getValue(s051_Genuine);
            MeanVector.getValue(s052_Genuine);
            MeanVector.getValue(s053_Genuine);
            MeanVector.getValue(s054_Genuine);
            MeanVector.getValue(s055_Genuine);
            MeanVector.getValue(s056_Genuine);
            MeanVector.getValue(s057_Genuine);
        #endregion


        #region Calculating the False Reject Rate
        /// <summary>
        /// Find a false reject rate at given threshold T, and the number of samples N. 
        /// </summary>
        /// <param name="s002_Genuine"> Find a Genuine Score</param>
        /// <param name="N">is number of samples</param>
        static void FalseRejectRate(double[,] s002_Genuine, int N)
        {
            Console.Write("---------------------------------------Answer C-------------------------------------------" + Environment.NewLine);
            Console.Write("-------------compute the genuine and impostor scores using Manhattan distance-------------" + Environment.NewLine);
            Console.Write("..........................................................................................." + Environment.NewLine);

            Console.Write("Enter any thresold for N number of samples " + N + " samples." + Environment.NewLine + "T = ");

            double threshold_FRR = double.Parse(Console.ReadLine());

            int impostor = 0, genuine = 0;
            int FRRAllSamples = N * 51;

            for (int i = 0; i < s002_Genuine.GetLength(0); i++)
            {
                for (int j = 0; j < s002_Genuine.GetLength(1); j++)
                {
                    if (threshold_FRR <= s002_Genuine[i, j])
                    {
                        impostor++;
                       /// Console.Write(impostor + " is Impostor Rate for " + FRRAllSamples + " Samples " + Environment.NewLine);

                    }
                                
                }
            }

            Console.Write(genuine + " is Genuine Score for" + N + "Samples" + Environment.NewLine + " And we can get Zero Effort Imposter rate at " + FRRAllSamples + "Samples" + Environment.NewLine);


            double FRR = Convert.ToDouble(impostor) / FRRAllSamples;

            Console.Write("The false reject rate using Manhattan varifier is FRR = " + FRR + " For N = " + N);
            Console.Write(" samples at threshold T = " + threshold_FRR + Environment.NewLine);

            #region In false case exit through the programs
            Console.Write("you wann Try again?" + Environment.NewLine + "Press y for Yes or n for No" + Environment.NewLine);
            string choice = Console.ReadLine();

            if (choice == "y")
            {
                Main();
            }

            if (choice == "n")
            {
                Console.Write("Thanks for using the KeyStroke Biomatric. Press any key to quit");
                Console.ReadKey();
            }
            #endregion
        }
        #endregion

        #region Calculating the impostor Pass Rate

        static void impostorPassRate(double[,] IPR1, double[,] IPR2, double[,] IPR3, double[,] IPR4, double[,] IPR5, double[,] IPR6, double[,] IPR7, double[,] IPR8, double[,] IPR9, double[,] IPR10, double[,] IPR11, double[,] IPR12, double[,] IPR13, double[,] IPR14, double[,] IPR15, double[,] IPR16, double[,] IPR17, double[,] IPR18, double[,] IPR19, double[,] IPR20, double[,] IPR21, double[,] IPR22, double[,] IPR23, double[,] IPR24, double[,] IPR25, double[,] IPR26, double[,] IPR27, double[,] IPR28, double[,] IPR29, double[,] IPR30, double[,] IPR31, double[,] IPR32, double[,] IPR33, double[,] IPR34, double[,] IPR35, double[,] IPR36, double[,] IPR37, double[,] IPR38, double[,] IPR39, double[,] IPR40, double[,] IPR41, double[,] IPR42, double[,] IPR43, double[,] IPR44, double[,] IPR45, double[,] IPR46, double[,] IPR47, double[,] IPR48, double[,] IPR49, double[,] IPR50, double T, int N)
        {

            impstorScore.getvalue(impostorPassRate);
            // 51 Subject/Typist/Subjects
            // 50 times each Subject  
            int totalScores = 51 * 50 * N;
            Console.Write("-----------------------------------------Answer B---------------------------------------------" + Environment.NewLine);
            Console.Write("-------calculate and report false accept and false reject rates at a given threshold T.-------" + Environment.NewLine);
            Console.Write("..............................................................................................." + Environment.NewLine);

            Console.Write("The Threshold T = " + T + " Sample size, N = " + N + "." + Environment.NewLine 
                + "Template using Mean Key Hold and Key Interval for N test sample is :" + totalScores + Environment.NewLine);
            int genuine = 0;

            for (int i = 0; i < IPR1.GetLength(0); i++)
            {
                for (int j = 0; j < IPR1.GetLength(1); j++)
                {
                    #region if IPR is <= Thresold then declared as genuine else Imposter
                   
                    if (IPR1[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR2[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR3[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR4[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR5[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR6[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR7[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR8[i, j] <= T)
                    {
                        genuine++;
                    }


                    if (IPR9[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR10[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR11[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR12[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR13[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR14[i, j] <= T)
                    {
                        genuine++;
                    }


                    if (IPR15[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR16[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR17[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR18[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR19[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR20[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR21[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR22[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR23[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR24[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR25[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR26[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR27[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR28[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR29[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR30[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR31[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR32[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR33[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR34[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR35[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR36[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR37[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR38[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR39[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR40[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR41[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR42[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR43[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR44[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR45[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR46[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR47[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR48[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR49[i, j] <= T)
                    {
                        genuine++;
                    }

                    if (IPR50[i, j] <= T)
                    {
                        genuine++;
                    }

                    else
                    {
                        Console.Write("");
                    }
                    #endregion
                }
            }

         ///  Console.WriteLine(genuine + " scores");

            double IPR = Convert.ToDouble(genuine) / totalScores;
            Console.WriteLine("So, For " + N + " samples the False Accept Rate  at " + T + " threshold is = " + IPR);
        }
        #endregion

        #region This method will calculate the genuine scores
        /// <summary>
        /// Genuine Score Calculation
        /// </summary>
        /// <param name="s002_Test">All 50 Test vector have 400 samples</param>
        /// <param name="mean_s002">mean vector of first 400 sample</param>
        /// <note>The Manhattan Verifier is calculated for the N samples</note>
        static double[,] calcGenuineScore(double[,] s002_Test, double[] mean_s002, int N)
        {
            // Initialize the array
            double[,] difference = new double[s002_Test.GetLength(0), 21];

            for (int i = 0; i < s002_Test.GetLength(0); i++)
            {
                for (int j = 0; j < s002_Test.GetLength(1); j++)
                {
                    //  the Manhattan Distance verifier difference
                    difference[i, j] += (Math.Abs(s002_Test[i, j] - mean_s002[j])) / 2;
                    string T = null;

                }
            }

            return difference;
        }
        #endregion

        #region The Test Sample from user choice condition

        static double[,] retriveTestVector(double[,] s002, int N)
        {
            if (N == 100)
            {
                double[,] test100 = new double[300, 21];

                for (int i = 0; i < 299; i++)
                {
                    for (int j = 0; j < test100.GetLength(1) - 1; j++)
                    {
                       
                        test100[i, j] = s002[100 + i, j];
                    }
                }
                return test100;
            }

            else if (N == 200)
            {
                double[,] test200 = new double[200, 21];

                for (int i = 0; i < 199; i++)
                {
                    for (int j = 0; j < test200.GetLength(1); j++)
                    {
                     
                        test200[i, j] = s002[200 + i, j];
                    }
                }
                return test200;
            }

            else if (N == 300)
            {
                double[,] test300 = new double[100, 21];

                for (int i = 0; i < 99; i++)
                {
                    for (int j = 0; j < test300.GetLength(1); j++)
                    {
                       
                        test300[i, j] = s002[300 + i, j];
                    }
                }
                return test300;
            }

            return s002; 
        }
        #endregion

        #region Extraction of training samples based on the value of N
        static double[,] RetriveTrainningVector(double[,] s002, int N)
        {
            // Initializing array
            double[,] samples = new double[N, 21];
            for (int n = 0; n <= N - 1; n++)
            {
                for (int j = 0; j < s002.GetLength(1); j++)
                {
                
                    samples[n, j] = s002[n, j];
                }
            }
            return samples;
        }
        #endregion

        #region Template Vector
        static double[] calcTemplateVector(double[,] s002_Samples, int N)
        {
            #region Create sum of all 
            double[] sum = new double[s002_Samples.GetLength(1)];
            double[] mean = new double[s002_Samples.GetLength(1)];
            #endregion

            for (int i = 0; i < s002_Samples.GetLength(0); i++)
            {
               
                for (int j = 0; j < s002_Samples.GetLength(1); j++)
                {
                    sum[j] += s002_Samples[i, j];
                    Console.Write("+ sum[j]");
                }
            }

            for (int k = 0; k < sum.Length; k++)
            {
                mean[k] = sum[k] / N;
               // Console.Write("Manhattan verifier for given sample" + Environment.NewLine + "mean");

            }
            return mean;
        }
        #endregion

       
}
