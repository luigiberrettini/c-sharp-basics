using Examples.CoreConstructs;
using Examples.Encapsulation;
using Examples.Exceptions;
using Examples.InheritanceAndPolymorphism;
using Examples.Interfaces;

namespace Examples
{
    public static class Launcher
    {
        public static void Main()
        {
            CoreConstructs();
            Encapsulation();
            InheritanceAndPolymorphism();
            Exceptions();
            Interfaces();
        }

        private static void CoreConstructs()
        {
            BasicConsoleIo.Go();
            ReturningErrors.Go(new[] { "hi", "2", "myTest" });
            BasicDataTypes.Go();
            FunWithStrings.Go();
            TypeConversions.Go();
            ImplicitlyTypedLocalVars.Go();
            Iterations.Go();
            Decisions.Go();

            FunWithMethods.Go();
            MethodOverloading.Go();
            FunWithArrays.Go();
            FunWithEnums.Go();
            FunWithStructures.Go();
            ValueAndReferenceTypes.Go();
            NullableTypes.Go();
        }

        private static void Encapsulation()
        {
            Classes.Go();
            StaticDataAndMembers.Go();
            UtilityClasses.Go();
            AccessorsMutatorsAndProps.Go();
            AutoProps.Go();
            ObjectInitializers.Go();
            ConstData.Go();
            PartialTypes.Go();
        }

        private static void InheritanceAndPolymorphism()
        {
            BasicInheritance.Go();
            ClassHierarchy.Go();
            Shapes.Go();
            ObjectOverrides.Go();
        }

        private static void Exceptions()
        {
            SimpleException.Go();
            CustomException.Go();
            MultipleExceptions.Go();
        }

        private static void Interfaces()
        {
            InterfaceUsage.Go();
            CustomInterface.Go();
            InterfaceNameClash.Go();
            InterfaceHierarchy.Go();
            CustomEnumerator.Go();
            Clonable.Go();
            Comparable.Go();
            MultipleInheritance.Go();
        }
    }
}