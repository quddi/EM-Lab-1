﻿using MathNet.Numerics.LinearAlgebra;
using System.Windows.Media;

namespace EM_Lab_1;

public static class Constants
{
    private static double? _normalDistributionQuantile;

    public const int ComputedPointsSize = 10;
    public const double Tolerance = 0.00000001;
    public const double Alpha = 0.05;
    public const double C0 = 2.515517;
    public const double C1 = 0.802853;
    public const double C2 = 0.010328;
    public const double D1 = 1.432788;
    public const double D2 = 0.1892659;
    public const double D3 = 0.001308;

    public static readonly Color OkColor = Color.FromRgb(161, 255, 162);
    public static readonly Color NotOkColor = Color.FromRgb(255, 164, 161);
    public static readonly Color ActiveColor = Color.FromRgb(204, 204, 204);
    public static readonly Color InactiveColor = Color.FromRgb(121, 121, 121);
    public static readonly System.Drawing.Color PlotPointsColor = System.Drawing.Color.DarkRed;
    public static readonly System.Drawing.Color PlotLinearColor = System.Drawing.Color.FromArgb(255, 200, 78, 195);
    public static readonly System.Drawing.Color PlotNotLinearColor = System.Drawing.Color.FromArgb(255, 78, 200, 83);
    public static readonly System.Drawing.Color PlotLinearComputedPointColor = System.Drawing.Color.FromArgb(255, 86, 226, 209);
    public static readonly System.Drawing.Color PlotLinearEdgesPointColor = System.Drawing.Color.FromArgb(255, 66, 206, 189);
    public static readonly System.Drawing.Color PlotNotLinearComputedPointColor = System.Drawing.Color.FromArgb(255, 252, 165, 56);
    public static readonly System.Drawing.Color PlotNotLinearEdgesPointColor = System.Drawing.Color.FromArgb(255, 232, 145, 36);

    public static readonly Brush OkBrush = new SolidColorBrush(OkColor);
    public static readonly Brush NotOkBrush = new SolidColorBrush(NotOkColor);

    public static readonly MatrixBuilder<double> MatrixBuilder = Matrix<double>.Build;
    public static readonly VectorBuilder<double> VectorBuilder = Vector<double>.Build;

    public static readonly string[] NotLinearParametersNames = ["A", "B", "C"];

    public static double NormalDistributionQuantile
    {
        get
        {
            if (_normalDistributionQuantile == null)
                _normalDistributionQuantile = Compute.NormalDistributionQuantile(1 - Alpha / 2);

            return _normalDistributionQuantile!.Value;
        }
    }
}
