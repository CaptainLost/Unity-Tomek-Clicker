using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BreakInfinity;

public static class PointsHelper
{
    private static readonly BigDouble mln = BigDouble.Pow(10, 6);
    private static readonly BigDouble mld = BigDouble.Pow(10, 9);

    private static readonly BigDouble bln = BigDouble.Pow(10, 12);
    private static readonly BigDouble bld = BigDouble.Pow(10, 15);

    private static readonly BigDouble tln = BigDouble.Pow(10, 18);
    private static readonly BigDouble tld = BigDouble.Pow(10, 21);

    private static readonly BigDouble kln = BigDouble.Pow(10, 24);
    private static readonly BigDouble kld = BigDouble.Pow(10, 27);

    public static string FormatPoints(BigDouble points)
    {
        if (points >= kld)
        {
            return (points / kld).ToString("F3") + "kld";
        }
        else if (points >= kln)
        {
            return (points / kln).ToString("F3") + "kln";
        }
        else if (points >= tld)
        {
            return (points / tld).ToString("F3") + "tld";
        }
        else if (points >= tln)
        {
            return (points / tln).ToString("F3") + "tln";
        }
        else if (points >= bld)
        {
            return (points / bld).ToString("F3") + "bld";
        }
        else if (points >= bln)
        {
            return (points / bln).ToString("F3") + "bln";
        }
        else if (points >= mld)
        {
            return (points / mld).ToString("F3") + "mld";
        }
        else if (points >= mln)
        {
            return (points / mln).ToString("F3") + "mln";
        }

        return points.ToString("F0");
    }
}
