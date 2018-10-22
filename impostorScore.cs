#region
using System;
using System.IO; // This is required for File I/O
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion

namespace ProgrammingAssignmentCSCI860M011155058
public class impostorScore
{
    #region Method to calculate the impostor Scores

    public static void FindIPRosterRate(double[,] s003_Test, double[,] s004_Test, double[,] s005_Test, double[,] s007_Test, double[,] s008_Test, double[,] s010_Test, double[,] s011_Test, double[,] s012_Test, double[,] s013_Test, double[,] s015_Test, double[,] s016_Test, double[,] s017_Test, double[,] s018_Test, double[,] s019_Test, double[,] s020_Test, double[,] s021_Test, double[,] s022_Test, double[,] s024_Test, double[,] s025_Test, double[,] s026_Test, double[,] s027_Test, double[,] s028_Test, double[,] s029_Test, double[,] s030_Test, double[,] s031_Test, double[,] s032_Test, double[,] s033_Test, double[,] s034_Test, double[,] s035_Test, double[,] s036_Test, double[,] s037_Test, double[,] s038_Test, double[,] s039_Test, double[,] s040_Test, double[,] s041_Test, double[,] s042_Test, double[,] s043_Test, double[,] s044_Test, double[,] s046_Test, double[,] s047_Test, double[,] s048_Test, double[,] s049_Test, double[,] s050_Test, double[,] s051_Test, double[,] s052_Test, double[,] s053_Test, double[,] s054_Test, double[,] s055_Test, double[,] s056_Test, double[,] s057_Test, int N, double[] mean_s002)
    {

        impostorScore impostorPassRate = new impostorScore();
        #region 50 double arrays that represent the impostor scores
        double[,] IPR1 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR2 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR3 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR4 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR5 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR6 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR7 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR8 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR9 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR10 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR11 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR12 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR13 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR14 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR15 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR16 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR17 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR18 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR19 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR20 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR21 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR22 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR23 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR24 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR25 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR26 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR27 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR28 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR29 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR30 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR31 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR32 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR33 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR34 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR35 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR36 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR37 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR38 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR39 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR40 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR41 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR42 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR43 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR44 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR45 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR46 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR47 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR48 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR49 = new double[s003_Test.GetLength(0), 21];
        double[,] IPR50 = new double[s003_Test.GetLength(0), 21];
        #endregion

        #region Fetch all data in single array. 
        for (int i = 0; i < s003_Test.GetLength(0); i++)
        {
            for (int j = 0; j < s003_Test.GetLength(1); j++)
            {
                IPR1[i, j] += (Math.Abs(s003_Test[i, j] - mean_s002[j]) / 2);
                IPR2[i, j] += (Math.Abs(s004_Test[i, j] - mean_s002[j]) / 2);
                IPR3[i, j] += (Math.Abs(s005_Test[i, j] - mean_s002[j]) / 2);
                IPR4[i, j] += (Math.Abs(s007_Test[i, j] - mean_s002[j]) / 2);
                IPR5[i, j] += (Math.Abs(s008_Test[i, j] - mean_s002[j]) / 2);
                IPR6[i, j] += (Math.Abs(s010_Test[i, j] - mean_s002[j]) / 2);
                IPR7[i, j] += (Math.Abs(s011_Test[i, j] - mean_s002[j]) / 2);
                IPR8[i, j] += (Math.Abs(s012_Test[i, j] - mean_s002[j]) / 2);
                IPR9[i, j] += (Math.Abs(s013_Test[i, j] - mean_s002[j]) / 2);
                IPR10[i, j] += (Math.Abs(s015_Test[i, j] - mean_s002[j]) / 2);
                IPR11[i, j] += (Math.Abs(s016_Test[i, j] - mean_s002[j]) / 2);
                IPR12[i, j] += (Math.Abs(s017_Test[i, j] - mean_s002[j]) / 2);
                IPR13[i, j] += (Math.Abs(s018_Test[i, j] - mean_s002[j]) / 2);
                IPR14[i, j] += (Math.Abs(s019_Test[i, j] - mean_s002[j]) / 2);
                IPR15[i, j] += (Math.Abs(s020_Test[i, j] - mean_s002[j]) / 2);
                IPR16[i, j] += (Math.Abs(s021_Test[i, j] - mean_s002[j]) / 2);
                IPR17[i, j] += (Math.Abs(s022_Test[i, j] - mean_s002[j]) / 2);
                IPR18[i, j] += (Math.Abs(s024_Test[i, j] - mean_s002[j]) / 2);
                IPR19[i, j] += (Math.Abs(s025_Test[i, j] - mean_s002[j]) / 2);
                IPR20[i, j] += (Math.Abs(s026_Test[i, j] - mean_s002[j]) / 2);
                IPR21[i, j] += (Math.Abs(s027_Test[i, j] - mean_s002[j]) / 2);
                IPR22[i, j] += (Math.Abs(s028_Test[i, j] - mean_s002[j]) / 2);
                IPR23[i, j] += (Math.Abs(s029_Test[i, j] - mean_s002[j]) / 2);
                IPR24[i, j] += (Math.Abs(s030_Test[i, j] - mean_s002[j]) / 2);
                IPR25[i, j] += (Math.Abs(s031_Test[i, j] - mean_s002[j]) / 2);
                IPR26[i, j] += (Math.Abs(s032_Test[i, j] - mean_s002[j]) / 2);
                IPR27[i, j] += (Math.Abs(s033_Test[i, j] - mean_s002[j]) / 2);
                IPR28[i, j] += (Math.Abs(s034_Test[i, j] - mean_s002[j]) / 2);
                IPR29[i, j] += (Math.Abs(s035_Test[i, j] - mean_s002[j]) / 2);
                IPR30[i, j] += (Math.Abs(s036_Test[i, j] - mean_s002[j]) / 2);
                IPR31[i, j] += (Math.Abs(s037_Test[i, j] - mean_s002[j]) / 2);
                IPR32[i, j] += (Math.Abs(s038_Test[i, j] - mean_s002[j]) / 2);
                IPR33[i, j] += (Math.Abs(s039_Test[i, j] - mean_s002[j]) / 2);
                IPR34[i, j] += (Math.Abs(s040_Test[i, j] - mean_s002[j]) / 2);
                IPR35[i, j] += (Math.Abs(s041_Test[i, j] - mean_s002[j]) / 2);
                IPR36[i, j] += (Math.Abs(s042_Test[i, j] - mean_s002[j]) / 2);
                IPR37[i, j] += (Math.Abs(s043_Test[i, j] - mean_s002[j]) / 2);
                IPR38[i, j] += (Math.Abs(s044_Test[i, j] - mean_s002[j]) / 2);
                IPR39[i, j] += (Math.Abs(s046_Test[i, j] - mean_s002[j]) / 2);
                IPR40[i, j] += (Math.Abs(s047_Test[i, j] - mean_s002[j]) / 2);
                IPR41[i, j] += (Math.Abs(s048_Test[i, j] - mean_s002[j]) / 2);
                IPR42[i, j] += (Math.Abs(s049_Test[i, j] - mean_s002[j]) / 2);
                IPR43[i, j] += (Math.Abs(s050_Test[i, j] - mean_s002[j]) / 2);
                IPR44[i, j] += (Math.Abs(s051_Test[i, j] - mean_s002[j]) / 2);
                IPR45[i, j] += (Math.Abs(s052_Test[i, j] - mean_s002[j]) / 2);
                IPR46[i, j] += (Math.Abs(s053_Test[i, j] - mean_s002[j]) / 2);
                IPR47[i, j] += (Math.Abs(s054_Test[i, j] - mean_s002[j]) / 2);
                IPR48[i, j] += (Math.Abs(s055_Test[i, j] - mean_s002[j]) / 2);
                IPR49[i, j] += (Math.Abs(s056_Test[i, j] - mean_s002[j]) / 2);
                IPR50[i, j] += (Math.Abs(s057_Test[i, j] - mean_s002[j]) / 2);
            }
        }
        #endregion

        Console.Write("Calculate the impostor Pass Rate, please enter any threshold T." + Environment.NewLine + "T = ");
        string threshold = Console.ReadLine();
        double T = double.Parse(threshold);
        // Method for storing IPR 
        impostorPassRate(IPR1, IPR2, IPR3, IPR4, IPR5, IPR6, IPR7, IPR8, IPR9, IPR10, IPR11, IPR12, IPR13, IPR14, IPR15, IPR16, IPR17, IPR18, IPR19, IPR20, IPR21, IPR22, IPR23, IPR24, IPR25, IPR26, IPR27, IPR28, IPR29, IPR30, IPR31, IPR32, IPR33, IPR34, IPR35, IPR36, IPR37, IPR38, IPR39, IPR40, IPR41, IPR42, IPR43, IPR44, IPR45, IPR46, IPR47, IPR48, IPR49, IPR50, T, N);
        impostorScore.setValue(impostorPassRate);
    }
    #endregion
}