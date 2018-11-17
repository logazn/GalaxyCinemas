using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GalaxyCinemas
{
    public class ImportResult
    {

        int totalRows;
        int importedRows;
        int failedRows;

        public List<String> ErrorMessages = new List<String>();
        
        public int ImportedRows { get => importedRows; set => importedRows = value; }
        public int TotalRows { get => totalRows; set => totalRows = value; }
        public int FailedRows { get => failedRows; set => failedRows = value; }
        public List<string> ErrorMessages1 { get => ErrorMessages; }

        
         public ImportResult()
        {
            totalRows = 0;
            importedRows = 0;
            failedRows = 0;
            ErrorMessages = null;
        }
    }
}
