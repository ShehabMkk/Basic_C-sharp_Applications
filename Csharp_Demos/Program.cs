//============================================================================================\\
//===================================== Demo_06 ==============================================\\
//============================================================================================\\

using System;

namespace Demo_01_OOP
{
    #region Part 01 & Part 02: Access Modifiers
    public class AccessModifiersExample
    {
        // Public member
        public string PublicMember = "I am public";

        // Private member
        private string PrivateMember = "I am private";

        // Protected member
        protected string ProtectedMember = "I am protected";

        // Internal member
        internal string InternalMember = "I am internal";

        public void ShowAccessModifiers()
        {
            Console.WriteLine(PublicMember);
            Console.WriteLine(PrivateMember);
            Console.WriteLine(ProtectedMember);
            Console.WriteLine(InternalMember);
        }
    }
    #endregion
    
    //====================================================================================\\

    #region Part 03 & Part 04: Struct Example
    public struct StructExample
    {
        public int X;
        public int Y;

        public StructExample(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void DisplayCoordinates()
        {
            Console.WriteLine($"X: {X}, Y: {Y}");
        }
    }
    #endregion
    
    //====================================================================================\\

    #region Part 05: OOP Overview
    public class OOPOverview
    {
        public void DemonstrateOOP()
        {
            Console.WriteLine("Object-Oriented Programming (OOP) allows for the modeling of real-world scenarios using classes and objects.");
        }
    }
    #endregion
    
    //====================================================================================\\

    #region Part 06: Encapsulation (Getter & Setter)
    public class EncapsulationExample1
    {
        private int _value;

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }
    #endregion
    
    //====================================================================================\\

    #region Part 07: Encapsulation (FullProperty)
    public class EncapsulationExample2
    {
        public int FullProperty { get; set; }
    }
    #endregion
    
    //====================================================================================\\

    #region Part 08: Encapsulation (Automatic Property)
    public class EncapsulationExample3
    {
        public int AutoProperty { get; set; }
    }
    #endregion
    
    //====================================================================================\\

    class Program
    {
        static void Main(string[] args)
        {
            #region Access Modifiers
            // AccessModifiersExample accessExample = new AccessModifiersExample();
            // accessExample.ShowAccessModifiers();
            #endregion

            #region Struct Example
            // StructExample structExample = new StructExample(10, 20);
            // structExample.DisplayCoordinates();
            #endregion

            #region OOP Overview
            // OOPOverview oopOverview = new OOPOverview();
            // oopOverview.DemonstrateOOP();
            #endregion

            #region Encapsulation (Getter & Setter)
            // EncapsulationExample1 encapsulation1 = new EncapsulationExample1();
            // encapsulation1.Value = 100;
            // Console.WriteLine($"Encapsulation (Getter & Setter) Value: {encapsulation1.Value}");
            #endregion

            #region Encapsulation (FullProperty)
            // EncapsulationExample2 encapsulation2 = new EncapsulationExample2();
            // encapsulation2.FullProperty = 200;
            // Console.WriteLine($"Encapsulation (FullProperty) Value: {encapsulation2.FullProperty}");
            #endregion

            #region Encapsulation (Automatic Property)
            // EncapsulationExample3 encapsulation3 = new EncapsulationExample3();
            // encapsulation3.AutoProperty = 300;
            // Console.WriteLine($"Encapsulation (Automatic Property) Value: {encapsulation3.AutoProperty}");
            #endregion
        }
    }
}
