//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace List_Drug
{
    using System;
    using System.Collections.Generic;
    
    public partial class Food_Interactions
    {
        public int Code_Food_Interactions { get; set; }
        public Nullable<int> Code_Drug { get; set; }
        public Nullable<int> Code_Group_Food { get; set; }
        public string Complications { get; set; }
        public string Descriptions { get; set; }
        public string Name_Food_Interactions { get; set; }
    
        public virtual Information_Drug Information_Drug { get; set; }
    }
}