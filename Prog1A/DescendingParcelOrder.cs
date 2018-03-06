// Program 0
// CIS 200-076
// Fall 2017
// Due: 11/27/2017
// By: D7010

//implements the decending sort for the parcel class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class DescendingParcelOrder : Comparer<Parcel>
    {
        //precondition: None
        //Postcondition: when p1<p2, returns positive number
        //              when p1=p2, returns zero
        //              when p1>p2, returns negative number
        public override int Compare(Parcel p1, Parcel p2)
        {
            //ensures null values are handled
            if(p1 == null & p2 == null)//both null is equal
            {
                return 0;
            }
            if(p1 == null)//p2 greater if only p1 null
            {
                return -1;
            }
            if(p2 == null)//p1 greater if p2 null
            {
                return 1;
            }

            return (-1) * p1.CompareTo(p2); //reverse natural order to be descending
        }
    }
}
