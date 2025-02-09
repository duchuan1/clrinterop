﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TlbImpRuleFileEditor {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TlbImpRuleFileEditor.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AddAttribute action is used to add some customized attribute to the corresponding managed types of the tlb types..
        /// </summary>
        internal static string Msg_ActionDescription_AddAttribute {
            get {
                return ResourceManager.GetString("Msg_ActionDescription_AddAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ChangeManagedName action is used to give tlb type a customized managed name instead of the default one..
        /// </summary>
        internal static string Msg_ActionDescription_ChangeManagedName {
            get {
                return ResourceManager.GetString("Msg_ActionDescription_ChangeManagedName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ConvertTo action is used to convert tlb function parameter to the user-specified managed signature. When converting a tlb function signature into managed function signature, TlbImp may not do as what we want, because TlbImp does not have all information. For example, “HRESULT  Func(int *intArray)” will be converted to “void Func (ref int intArray)”. ConvertTo action can convert the “int *” to a fixed array, for example, “void Func (int[20] intArray)”..
        /// </summary>
        internal static string Msg_ActionDescription_ConvertTo {
            get {
                return ResourceManager.GetString("Msg_ActionDescription_ConvertTo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In a normal function conversion process, TlbImp will use the [out, retval] parameter as the return value to substitute HResult return value and when error occurs, an exception will be thrown. If we perform a function conversion with PreserveSig, the original signature will be preserved, and TlbImp will not put the [out, retval] parameter in the return place in the function signature..
        /// </summary>
        internal static string Msg_ActionDescription_PreserveSig {
            get {
                return ResourceManager.GetString("Msg_ActionDescription_PreserveSig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In the conversion process, when TlbImp comes across some unknown tlb type, TlbImp will try to resolve this new tlb type to a managed type. ResolveTo action is used to resolve a tlb type to a user-specified managed type..
        /// </summary>
        internal static string Msg_ActionDescription_ResolveTo {
            get {
                return ResourceManager.GetString("Msg_ActionDescription_ResolveTo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to double click sub nodes to edit....
        /// </summary>
        internal static string Msg_EditUninitializedActionTip {
            get {
                return ResourceManager.GetString("Msg_EditUninitializedActionTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please select Category and Action to create a new rule. After a new rule is created, please go to the rule file panel in the main dialog to edit the Condition and Action..
        /// </summary>
        internal static string Msg_InstructionAboutAddNewRule {
            get {
                return ResourceManager.GetString("Msg_InstructionAboutAddNewRule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TlbImp Config File Editor.
        /// </summary>
        internal static string Msg_MainFormTitle {
            get {
                return ResourceManager.GetString("Msg_MainFormTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This action does not have any parameters to edit..
        /// </summary>
        internal static string Msg_NoParametersToEdit {
            get {
                return ResourceManager.GetString("Msg_NoParametersToEdit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No rule file to save..
        /// </summary>
        internal static string Msg_NoRuleFileToSave {
            get {
                return ResourceManager.GetString("Msg_NoRuleFileToSave", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to delete all rules?.
        /// </summary>
        internal static string Msg_RemoveAllRuleQuestion {
            get {
                return ResourceManager.GetString("Msg_RemoveAllRuleQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove All Rules.
        /// </summary>
        internal static string Msg_RemoveAllRuleTitle {
            get {
                return ResourceManager.GetString("Msg_RemoveAllRuleTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to delete all subconditions of the condition &apos;{0}&apos;?.
        /// </summary>
        internal static string Msg_RemoveAllSubconditionQuestion {
            get {
                return ResourceManager.GetString("Msg_RemoveAllSubconditionQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove All Subconditions.
        /// </summary>
        internal static string Msg_RemoveAllSubconditionTitle {
            get {
                return ResourceManager.GetString("Msg_RemoveAllSubconditionTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to delete the condition &quot;{0}&quot;?.
        /// </summary>
        internal static string Msg_RemoveConditionQuestion {
            get {
                return ResourceManager.GetString("Msg_RemoveConditionQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove Condition.
        /// </summary>
        internal static string Msg_RemoveConditionTitle {
            get {
                return ResourceManager.GetString("Msg_RemoveConditionTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to delete the rule &apos;{0}&apos;?.
        /// </summary>
        internal static string Msg_RemoveRuleQuestion {
            get {
                return ResourceManager.GetString("Msg_RemoveRuleQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove Rule.
        /// </summary>
        internal static string Msg_RemoveRuleTitle {
            get {
                return ResourceManager.GetString("Msg_RemoveRuleTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The current rules have some changes. Do you want to save the changes?.
        /// </summary>
        internal static string Msg_SaveFileQuestion {
            get {
                return ResourceManager.GetString("Msg_SaveFileQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Save File.
        /// </summary>
        internal static string Msg_SaveFileQuestionTitle {
            get {
                return ResourceManager.GetString("Msg_SaveFileQuestionTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;double click to open a .tlb file…&gt;.
        /// </summary>
        internal static string Msg_TypeLibTreeRootDefaultText {
            get {
                return ResourceManager.GetString("Msg_TypeLibTreeRootDefaultText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The action of rule &apos;{0}&apos; is not initialized..
        /// </summary>
        internal static string Wrn_ActionUninitialized {
            get {
                return ResourceManager.GetString("Wrn_ActionUninitialized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot load assembly &apos;{0}&apos;..
        /// </summary>
        internal static string Wrn_AssemblyLoadFailed {
            get {
                return ResourceManager.GetString("Wrn_AssemblyLoadFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The input parameter value &apos;{0}&apos; for type &apos;{1}&apos; is invalid..
        /// </summary>
        internal static string Wrn_BadParameterInput {
            get {
                return ResourceManager.GetString("Wrn_BadParameterInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot use byte data input helper, because constructor &apos;{0}&apos; cannot be found in the type &apos;{1}&apos;..
        /// </summary>
        internal static string Wrn_CannotUseByteDataInputHelper_CtorNotFound {
            get {
                return ResourceManager.GetString("Wrn_CannotUseByteDataInputHelper_CtorNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot use byte data input helper. Select a constructor first..
        /// </summary>
        internal static string Wrn_CannotUseByteDataInputHelper_CtorNotSelected {
            get {
                return ResourceManager.GetString("Wrn_CannotUseByteDataInputHelper_CtorNotSelected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot use byte data input helper. Input helper do not support parameter type &apos;{0}&apos;..
        /// </summary>
        internal static string Wrn_CannotUseByteDataInputHelper_ParameterNotSupported {
            get {
                return ResourceManager.GetString("Wrn_CannotUseByteDataInputHelper_ParameterNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attribute type is null or not loaded successfully. Cannot use byte data input helper..
        /// </summary>
        internal static string Wrn_CannotUseByteDataInputHelper_TypeNotLoaded {
            get {
                return ResourceManager.GetString("Wrn_CannotUseByteDataInputHelper_TypeNotLoaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Condition &apos;{0}&apos; should have at least one sub condition..
        /// </summary>
        internal static string Wrn_EmptyCompositeCondition {
            get {
                return ResourceManager.GetString("Wrn_EmptyCompositeCondition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The byte data is invalid. Input data in the hexadecimal way..
        /// </summary>
        internal static string Wrn_InvalidByteData {
            get {
                return ResourceManager.GetString("Wrn_InvalidByteData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The condition is not complete. The previous modification is not accepted..
        /// </summary>
        internal static string Wrn_InvalidCondition {
            get {
                return ResourceManager.GetString("Wrn_InvalidCondition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;SizeParamIndexOffset&apos; is invalid..
        /// </summary>
        internal static string Wrn_InvalidSizeParamIndexOffset {
            get {
                return ResourceManager.GetString("Wrn_InvalidSizeParamIndexOffset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot open rule file &apos;{0}&apos;. The xml format is invalid..
        /// </summary>
        internal static string Wrn_LoadRuleFileFailed {
            get {
                return ResourceManager.GetString("Wrn_LoadRuleFileFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; of Assembly &apos;{1}&apos; cannot be loaded..
        /// </summary>
        internal static string Wrn_ManagedTypeCannotBeLoaded {
            get {
                return ResourceManager.GetString("Wrn_ManagedTypeCannotBeLoaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No managed type is selected. Select a type in the treeview first please..
        /// </summary>
        internal static string Wrn_NoManagedTypeSelected_TypeSelector {
            get {
                return ResourceManager.GetString("Wrn_NoManagedTypeSelected_TypeSelector", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No rule file to add rule to..
        /// </summary>
        internal static string Wrn_NoRuleFileToAddRuleTo {
            get {
                return ResourceManager.GetString("Wrn_NoRuleFileToAddRuleTo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No type library type is selected..
        /// </summary>
        internal static string Wrn_NoTlbTypeSelected_TlbTypeSelector {
            get {
                return ResourceManager.GetString("Wrn_NoTlbTypeSelected_TlbTypeSelector", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parsing byte data according to constructor &apos;{0}&apos; failed. The data does not match with the parameter list of the constructor..
        /// </summary>
        internal static string Wrn_ParseDataFailed {
            get {
                return ResourceManager.GetString("Wrn_ParseDataFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Saving rule file failed. There exists invalid rule. Please check the conditions before saving..
        /// </summary>
        internal static string Wrn_SaveRuleFileFailed {
            get {
                return ResourceManager.GetString("Wrn_SaveRuleFileFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your change of this node, will cause some of its subconditions lost. Do you want to continue the change?.
        /// </summary>
        internal static string Wrn_SubconditionLost {
            get {
                return ResourceManager.GetString("Wrn_SubconditionLost", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Condition Lost.
        /// </summary>
        internal static string Wrn_SubconditionLostTitle {
            get {
                return ResourceManager.GetString("Wrn_SubconditionLostTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot load type library &apos;{0}&apos;..
        /// </summary>
        internal static string Wrn_TypeLibLoadFailed {
            get {
                return ResourceManager.GetString("Wrn_TypeLibLoadFailed", resourceCulture);
            }
        }
    }
}
