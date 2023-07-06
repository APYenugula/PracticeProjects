


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask.Models
{
    //public class TempRecord
    //{
    //    // Array of temperature values
    //    int[] temps = new int[6]
    //    {
    //    56, 26, 116, 54, 38,
    //    431 };

    //    // To enable client code to validate input
    //    // when accessing your indexer.
    //    public int Length => temps.Length;

    //    // Indexer declaration.
    //    // If index is out of range, the temps array will throw the exception.
    //    public int this[int index]
    //    {
    //        get => temps[index];
    //        set => temps[index] = value;
    //    }
    //}

    //public class BikeParts
    //{
    //    public string Name { get; set; }
    //    public string Part1 { get; set; }
    //    public string Part2 { get; set; }
    //    public string Part3 { get; set; }

    //}

    //public class Bikes
    //{
    //    BikeParts[] parts = new BikeParts[3];

    //    public BikeParts this[int index]
    //    {
    //        get => parts[index];
    //        set => parts[index] = value;
    //    }


    //}
    //public class IE
    //{
    //    float[] arr=new float[3];
    //    public float this[int index]
    //    {
    //        get => arr[index]; set => arr[index] = value;
    //    }
    //}
    //public class Student
    //{
    //    public int id { get; set; }
    //    public string Name { get; set; }
    //}
    //public class A
    //{

    //}
    public class A
    {
        int[] w = new int[3];
        public int this[int index]
        { 
            get =>w[index]; 
            set => w[index] = value;  
        }
    }
    public class BikeParts
    {
        public int last2digits { get; set; }
        public  string company { get; set; }
        public string color { get; set; }
    }
    public class Bike
    {
        BikeParts[] ob2=new BikeParts[3];
        public BikeParts this[int index]
        {
            get => ob2[index];
            set => ob2[index] = value;
        }

    }
}
