//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _20._101_Nevrotova_3.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentResult
    {
        public int IdStudentResult { get; set; }
        public int IdStudent { get; set; }
        public int IdCriteria { get; set; }
        public string NumberOfPointsForCriteria { get; set; }
    
        public virtual Criteria Criteria { get; set; }
        public virtual Student Student { get; set; }
    }
}
