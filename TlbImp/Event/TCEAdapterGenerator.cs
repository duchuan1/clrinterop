﻿///////////////////////////////////////////////////////////////////////////////
// Copyright (c) Microsoft Corporation. All rights reserved.
///////////////////////////////////////////////////////////////////////////////
//
// Type Library Importer utility
//
// This program imports all the types in the type library into a interop assembly
//
///////////////////////////////////////////////////////////////////////////////

namespace tlbimp2.Event
{
    using System.Runtime.InteropServices;
    using System;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Collections;
    using System.Threading;
    using System.Collections.Generic;

    internal class TCEAdapterGenerator
    {
        public void Process(ModuleBuilder ModBldr, List<EventItfInfo> EventItfList)
        {
            // Store the input/output module.
            m_Module = ModBldr;

            // Generate the TCE adapters for all the event sources.
            int NumEvItfs = EventItfList.Count;
            for (int cEventItfs = 0; cEventItfs < NumEvItfs; cEventItfs++)
            {
                // Retrieve the event interface info.
                EventItfInfo CurrEventItf = EventItfList[cEventItfs];

                // Retrieve the information from the event interface info.
                Type EventItfType = CurrEventItf.GetEventItfType();
                Type SrcItfType = CurrEventItf.GetSrcItfType();
                String EventProviderName = CurrEventItf.GetEventProviderName();

                // Generate the sink interface helper.
                Type SinkHelperType = new EventSinkHelperWriter(m_Module, SrcItfType, EventItfType).Perform();

                // Generate the event provider.
                new EventProviderWriter(m_Module, EventProviderName, EventItfType, SrcItfType, SinkHelperType).Perform();
            }
        }

        internal static void SetClassInterfaceTypeToNone(TypeBuilder tb)
        {
            // Create the ClassInterface(ClassInterfaceType.None) CA builder if we haven't created it yet.
            if (s_NoClassItfCABuilder == null)
            {
                s_NoClassItfCABuilder = CustomAttributeHelper.GetBuilderForClassInterface(ClassInterfaceType.None);
            }

            // Set the class interface type to none.
            tb.SetCustomAttribute(s_NoClassItfCABuilder);
        }

        internal static TypeBuilder DefineUniqueType(String strInitFullName, TypeAttributes attrs, Type BaseType, Type[] aInterfaceTypes, ModuleBuilder mb)
        {
            String strFullName = strInitFullName;
            int PostFix = 2;

            // Find the first unique name for the type.
            for (; mb.GetType(strFullName) != null; strFullName = strInitFullName + "_" + PostFix, PostFix++) ;

            // Define a type with the determined unique name.
            return mb.DefineType(strFullName, attrs, BaseType, aInterfaceTypes);
        }

        internal static void SetHiddenAttribute(TypeBuilder tb)
        {
            if (s_HiddenCABuilder == null)
            {
                s_HiddenCABuilder = CustomAttributeHelper.GetBuilderForTypeLibType(TypeLibTypeFlags.FHidden);
            }

            tb.SetCustomAttribute(s_HiddenCABuilder);
        }

        internal static MethodInfo[] GetNonPropertyMethods(Type type)
        {
            MethodInfo[] aMethods = type.GetMethods();
            ArrayList methods = new ArrayList(aMethods);

            PropertyInfo[] props = type.GetProperties();

            foreach (PropertyInfo prop in props)
            {
                MethodInfo[] accessors = prop.GetAccessors();
                foreach (MethodInfo accessor in accessors)
                {
                    for (int i = 0; i < methods.Count; i++)
                    {
                        if ((MethodInfo)methods[i] == accessor)
                            methods.RemoveAt(i);
                    }
                }
            }

            MethodInfo[] retMethods = new MethodInfo[methods.Count];
            methods.CopyTo(retMethods);

            return retMethods;
        }

        internal static MethodInfo[] GetPropertyMethods(Type type)
        {
            MethodInfo[] aMethods = type.GetMethods();
            ArrayList methods = new ArrayList();

            PropertyInfo[] props = type.GetProperties();

            foreach (PropertyInfo prop in props)
            {
                MethodInfo[] accessors = prop.GetAccessors();
                foreach (MethodInfo accessor in accessors)
                {
                    methods.Add(accessor);
                }
            }

            MethodInfo[] retMethods = new MethodInfo[methods.Count];
            methods.CopyTo(retMethods);

            return retMethods;
        }


        private ModuleBuilder m_Module = null;
        private Hashtable m_SrcItfToSrcItfInfoMap = new Hashtable();
        private static CustomAttributeBuilder s_NoClassItfCABuilder = null;
        private static CustomAttributeBuilder s_HiddenCABuilder = null;
    }
}
