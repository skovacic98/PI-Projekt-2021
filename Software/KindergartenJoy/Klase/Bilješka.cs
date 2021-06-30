﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindergartenJoy
{
    public partial class biljeska
    {
        public int KorisnikId { get; set; }
        public int DijeteId { get; set; }
        public string Sadržaj { get; set; }
        public DateTime Datum { get; set; }

        internal static List<biljeska> DohvatiListuBilješki()
        {
            using (var context = new Entities())
            {
                List<biljeska> listaBilješki = context.biljeska.ToList();
                return listaBilješki;
            }
        }
    }
}
