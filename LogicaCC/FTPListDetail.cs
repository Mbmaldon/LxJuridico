﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCC
{
    public class FTPListDetail
    {
        public string Dir { get; set; }
        public string Permission { get; set; }
        public string Filecode { get; set; }
        public string Owner { get; set; }
        public string Group { get; set; }
        public string Name { get; set; }
        public string FullPath { get; set; }

        public bool IsDirectory
        {
            get
            {
                return !string.IsNullOrWhiteSpace(Dir) && Dir.ToLower().Equals("d");
            }
        }
    }
}
