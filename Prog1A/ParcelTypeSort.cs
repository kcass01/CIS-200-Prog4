// Program 0
// CIS 200-076
// Fall 2017
// Due: 11/27/2017
// By: D7010

//implements the multi level sort for the parcel class
//first by type, then by cost in descending

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class ParcelTypeSort : Comparer<Parcel>
    {
        //precondition:None
        //Postcondition: p1<p2, negative
        //              p1==p2, 0
        //              p1>p2, positive
        public override int Compare(Parcel p1, Parcel p2)
        {
            if (p1 == null & p2 == null)//both null is equal
            {
                return 0;
            }
            if (p1 == null)//p2 greater if only p1 null
            {
                return -1;
            }
            if (p2 == null)//p1 greater if p2 null
            {
                return 1;
            }

            if (p1.GetType() != p2.GetType()) //first check if different type, 
            {
                return p1.GetType().ToString().CompareTo(p2.GetType().ToString()); //use type to decide
            }
            else//then check by calc cost
            {
                return (-1) * p1.CompareTo(p2); //reverse natural order to be descending
            }
        }
    }
}
