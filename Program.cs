﻿using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using DocumentPlagiarismChecker.Core;

namespace DocumentPlagiarismChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0 || args[0] == null) throw new FolderNotSpecifiedException();
            if(args.Length == 1 || args[1] == null) throw new FileExtensionNotSpecifiedException();

            List<FileMatchingScore> results = API.CompareFiles(args[0], args[1]);            
            API.WriteOutput(results);        
            
            /*                      
                PENDING:                                
                    It will be possible to setup some configuration inside an XML file (for example, kind of output and number of check plugins to use (all by default)).                    
                    It will be possible to send a layout file in order to exclude its content from the comparisson.
                    It will be possible to set the threshold for each comparer in order to alert if its exceeded.
                    Paragraph word counter plugin.
             */
        }

        
    }
}
