﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new Model1())
            {
                foreach (var item in ctx.tbl_Rezervasyonlar)
                {
                    Console.WriteLine(item.tbl_Musteriler.Ad);
                }
            }
            Console.ReadLine();
        }
    }
}
