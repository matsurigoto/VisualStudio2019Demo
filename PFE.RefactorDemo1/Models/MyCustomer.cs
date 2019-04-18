using System;


namespace PFE.RefactorDemo1.Models
{
    public class MyCustomer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }

        public NestedData Level2Data = new NestedData();
    }

    public class NestedData
    {
        public int Number = 1;
        public string[] Collection = { "Sky", "Hank", "Benson" };

        public OtherNestData Level3Data = new OtherNestData();
    }

    public class OtherNestData
    {
        public DateTime CreatedData = DateTime.Now;

        public DeepNestData Level4Data = new DeepNestData();
    }

    public class DeepNestData
    {
        public int Level = 4;
    }
}

//DEMO : search depth