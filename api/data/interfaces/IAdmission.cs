using System.Collections.Generic;
using System.Threading.Tasks;
using dataswitch.Model;

namespace dataswitch.data.interfaces 
{
    public interface IAdmission
    {
        public Task<List<Admission>> getAllAdmissions();
        public Task<List<ProcedureInfo>> getAllProcedureInfo();
  
    }
    
}