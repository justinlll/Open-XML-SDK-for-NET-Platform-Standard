﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Utility.Xml {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal Strings() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Utility.Xml.Strings", typeof(Strings).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Cannot create node of type {0}..
        /// </summary>
        public static string Arg_CannotCreateNode {
            get {
                return ResourceManager.GetString("Arg_CannotCreateNode", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The XmlReader passed in to construct this XmlValidatingReaderImpl must be an instance of a System.Xml.XmlTextReader..
        /// </summary>
        public static string Arg_ExpectingXmlTextReader {
            get {
                return ResourceManager.GetString("Arg_ExpectingXmlTextReader", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Type is incompatible..
        /// </summary>
        public static string Arg_IncompatibleParamType {
            get {
                return ResourceManager.GetString("Arg_IncompatibleParamType", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The &apos;Attribute&apos; node cannot be inserted because it is already an attribute of another element..
        /// </summary>
        public static string Xdom_Attr_InUse {
            get {
                return ResourceManager.GetString("Xdom_Attr_InUse", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The attribute local name cannot be empty..
        /// </summary>
        public static string Xdom_Attr_Name {
            get {
                return ResourceManager.GetString("Xdom_Attr_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The namespace declaration attribute has an incorrect &apos;namespaceURI&apos;: &apos;{0}&apos;..
        /// </summary>
        public static string Xdom_Attr_Reserved_XmlNS {
            get {
                return ResourceManager.GetString("Xdom_Attr_Reserved_XmlNS", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The reference node must be a child of the current node..
        /// </summary>
        public static string Xdom_AttrCol_Insert {
            get {
                return ResourceManager.GetString("Xdom_AttrCol_Insert", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to An &apos;Attributes&apos; collection can only contain &apos;Attribute&apos; objects..
        /// </summary>
        public static string Xdom_AttrCol_Object {
            get {
                return ResourceManager.GetString("Xdom_AttrCol_Object", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The &apos;InnerText&apos; of a &apos;Document&apos; node is read-only and cannot be set..
        /// </summary>
        public static string Xdom_Document_Innertext {
            get {
                return ResourceManager.GetString("Xdom_Document_Innertext", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to This document already has an &apos;XmlDeclaration&apos; node..
        /// </summary>
        public static string Xdom_DualDeclarationNode {
            get {
                return ResourceManager.GetString("Xdom_DualDeclarationNode", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to This document already has a &apos;DocumentElement&apos; node..
        /// </summary>
        public static string Xdom_DualDocumentElementNode {
            get {
                return ResourceManager.GetString("Xdom_DualDocumentElementNode", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to This document already has a &apos;DocumentType&apos; node..
        /// </summary>
        public static string Xdom_DualDocumentTypeNode {
            get {
                return ResourceManager.GetString("Xdom_DualDocumentTypeNode", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The prefix of an element name cannot start with &apos;xml&apos;..
        /// </summary>
        public static string Xdom_Ele_Prefix {
            get {
                return ResourceManager.GetString("Xdom_Ele_Prefix", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The local name for elements or attributes cannot be null or an empty string..
        /// </summary>
        public static string Xdom_Empty_LocalName {
            get {
                return ResourceManager.GetString("Xdom_Empty_LocalName", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The &apos;InnerText&apos; of an &apos;Entity&apos; node is read-only and cannot be set..
        /// </summary>
        public static string Xdom_Ent_Innertext {
            get {
                return ResourceManager.GetString("Xdom_Ent_Innertext", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &apos;EntityReference&apos; nodes have no support for setting value..
        /// </summary>
        public static string Xdom_EntRef_SetVal {
            get {
                return ResourceManager.GetString("Xdom_EntRef_SetVal", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The element list has changed. The enumeration operation failed to continue..
        /// </summary>
        public static string Xdom_Enum_ElementList {
            get {
                return ResourceManager.GetString("Xdom_Enum_ElementList", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Cannot import nodes of type &apos;{0}&apos;..
        /// </summary>
        public static string Xdom_Import {
            get {
                return ResourceManager.GetString("Xdom_Import", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Cannot import a null node..
        /// </summary>
        public static string Xdom_Import_NullNode {
            get {
                return ResourceManager.GetString("Xdom_Import_NullNode", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The index being passed in is out of range..
        /// </summary>
        public static string Xdom_IndexOutOfRange {
            get {
                return ResourceManager.GetString("Xdom_IndexOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &apos;{0}&apos; does not represent any &apos;XmlNodeType&apos;..
        /// </summary>
        public static string Xdom_Invalid_NT_String {
            get {
                return ResourceManager.GetString("Xdom_Invalid_NT_String", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Cannot create an &apos;EntityReference&apos; node with a name starting with &apos;#&apos;..
        /// </summary>
        public static string Xdom_InvalidCharacter_EntityReference {
            get {
                return ResourceManager.GetString("Xdom_InvalidCharacter_EntityReference", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The document to be loaded could not be found..
        /// </summary>
        public static string Xdom_Load_NoDocument {
            get {
                return ResourceManager.GetString("Xdom_Load_NoDocument", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to There is no reader from which to load the document..
        /// </summary>
        public static string Xdom_Load_NoReader {
            get {
                return ResourceManager.GetString("Xdom_Load_NoReader", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The named node is from a different document context..
        /// </summary>
        public static string Xdom_NamedNode_Context {
            get {
                return ResourceManager.GetString("Xdom_NamedNode_Context", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &apos;Entity&apos; and &apos;Notation&apos; nodes cannot be cloned..
        /// </summary>
        public static string Xdom_Node_Cloning {
            get {
                return ResourceManager.GetString("Xdom_Node_Cloning", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Cannot insert a node or any ancestor of that node as a child of itself..
        /// </summary>
        public static string Xdom_Node_Insert_Child {
            get {
                return ResourceManager.GetString("Xdom_Node_Insert_Child", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The current node cannot contain other nodes..
        /// </summary>
        public static string Xdom_Node_Insert_Contain {
            get {
                return ResourceManager.GetString("Xdom_Node_Insert_Contain", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The node to be inserted is from a different document context..
        /// </summary>
        public static string Xdom_Node_Insert_Context {
            get {
                return ResourceManager.GetString("Xdom_Node_Insert_Context", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Cannot insert the node in the specified location..
        /// </summary>
        public static string Xdom_Node_Insert_Location {
            get {
                return ResourceManager.GetString("Xdom_Node_Insert_Location", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The reference node is not a child of this node..
        /// </summary>
        public static string Xdom_Node_Insert_Path {
            get {
                return ResourceManager.GetString("Xdom_Node_Insert_Path", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The specified node cannot be inserted as the valid child of this node, because the specified node is the wrong type..
        /// </summary>
        public static string Xdom_Node_Insert_TypeConflict {
            get {
                return ResourceManager.GetString("Xdom_Node_Insert_TypeConflict", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to This node is read-only. It cannot be modified..
        /// </summary>
        public static string Xdom_Node_Modify_ReadOnly {
            get {
                return ResourceManager.GetString("Xdom_Node_Modify_ReadOnly", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Cannot create a node without an owner document..
        /// </summary>
        public static string Xdom_Node_Null_Doc {
            get {
                return ResourceManager.GetString("Xdom_Node_Null_Doc", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The node to be removed is not a child of this node..
        /// </summary>
        public static string Xdom_Node_Remove_Child {
            get {
                return ResourceManager.GetString("Xdom_Node_Remove_Child", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The current node cannot contain other nodes, so the node to be removed is not its child..
        /// </summary>
        public static string Xdom_Node_Remove_Contain {
            get {
                return ResourceManager.GetString("Xdom_Node_Remove_Contain", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Cannot set a value on node type &apos;{0}&apos;..
        /// </summary>
        public static string Xdom_Node_SetVal {
            get {
                return ResourceManager.GetString("Xdom_Node_SetVal", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The document does not have a root element..
        /// </summary>
        public static string Xdom_NoRootEle {
            get {
                return ResourceManager.GetString("Xdom_NoRootEle", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Cannot set the &apos;InnerXml&apos; for the current node because it is either read-only or cannot have children..
        /// </summary>
        public static string Xdom_Set_InnerXml {
            get {
                return ResourceManager.GetString("Xdom_Set_InnerXml", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Wrong value for the XML declaration standalone attribute of &apos;{0}&apos;..
        /// </summary>
        public static string Xdom_standalone {
            get {
                return ResourceManager.GetString("Xdom_standalone", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The &apos;Text&apos; node is not connected in the DOM live tree. No &apos;SplitText&apos; operation could be performed..
        /// </summary>
        public static string Xdom_TextNode_SplitText {
            get {
                return ResourceManager.GetString("Xdom_TextNode_SplitText", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Wrong XML version information. The XML must match production \&quot;VersionNum ::= &apos;1.&apos; [0-9]+\&quot;..
        /// </summary>
        public static string Xdom_Version {
            get {
                return ResourceManager.GetString("Xdom_Version", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The string for white space contains an invalid character..
        /// </summary>
        public static string Xdom_WS_Char {
            get {
                return ResourceManager.GetString("Xdom_WS_Char", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The &apos;{0}&apos; character, hexadecimal value {1}, cannot be included in a name..
        /// </summary>
        public static string Xml_BadNameChar {
            get {
                return ResourceManager.GetString("Xml_BadNameChar", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Name cannot begin with the &apos;{0}&apos; character, hexadecimal value {1}..
        /// </summary>
        public static string Xml_BadStartNameChar {
            get {
                return ResourceManager.GetString("Xml_BadStartNameChar", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Cannot bind to the reserved namespace..
        /// </summary>
        public static string Xml_CanNotBindToReservedNamespace {
            get {
                return ResourceManager.GetString("Xml_CanNotBindToReservedNamespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The Writer is closed..
        /// </summary>
        public static string Xml_Closed {
            get {
                return ResourceManager.GetString("Xml_Closed", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The Writer is closed or in error state..
        /// </summary>
        public static string Xml_ClosedOrError {
            get {
                return ResourceManager.GetString("Xml_ClosedOrError", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Cannot write XML declaration. WriteStartDocument method has already written it..
        /// </summary>
        public static string Xml_DupXmlDecl {
            get {
                return ResourceManager.GetString("Xml_DupXmlDecl", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The empty string &apos;&apos; is not a valid name..
        /// </summary>
        public static string Xml_EmptyName {
            get {
                return ResourceManager.GetString("Xml_EmptyName", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Cannot have &apos;]]&gt;&apos; inside an XML CDATA block..
        /// </summary>
        public static string Xml_InvalidCDataChars {
            get {
                return ResourceManager.GetString("Xml_InvalidCDataChars", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &apos;{0}&apos;, hexadecimal value {1}, is an invalid character..
        /// </summary>
        public static string Xml_InvalidCharacter {
            get {
                return ResourceManager.GetString("Xml_InvalidCharacter", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to An XML comment cannot contain &apos;--&apos;, and &apos;-&apos; cannot be the last character..
        /// </summary>
        public static string Xml_InvalidCommentChars {
            get {
                return ResourceManager.GetString("Xml_InvalidCommentChars", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Indentation value must be greater than 0..
        /// </summary>
        public static string Xml_InvalidIndentation {
            get {
                return ResourceManager.GetString("Xml_InvalidIndentation", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Invalid name character in &apos;{0}&apos;..
        /// </summary>
        public static string Xml_InvalidNameChars {
            get {
                return ResourceManager.GetString("Xml_InvalidNameChars", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Invalid name character in &apos;{0}&apos;. The &apos;{1}&apos; character, hexadecimal value {2}, cannot be included in a name..
        /// </summary>
        public static string Xml_InvalidNameCharsDetail {
            get {
                return ResourceManager.GetString("Xml_InvalidNameCharsDetail", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Operation is not valid due to the current state of the object..
        /// </summary>
        public static string Xml_InvalidOperation {
            get {
                return ResourceManager.GetString("Xml_InvalidOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Cannot have &apos;?&gt;&apos; inside an XML processing instruction..
        /// </summary>
        public static string Xml_InvalidPiChars {
            get {
                return ResourceManager.GetString("Xml_InvalidPiChars", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Prefixes beginning with \&quot;xml\&quot; (regardless of whether the characters are uppercase, lowercase, or some combination thereof) are reserved for use by XML..
        /// </summary>
        public static string Xml_InvalidPrefix {
            get {
                return ResourceManager.GetString("Xml_InvalidPrefix", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Invalid XML attribute quote character. Valid attribute quote characters are &apos; and \&quot;..
        /// </summary>
        public static string Xml_InvalidQuote {
            get {
                return ResourceManager.GetString("Xml_InvalidQuote", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Invalid high surrogate character (0x{0}). A high surrogate character must have a value from range (0xD800 - 0xDBFF)..
        /// </summary>
        public static string Xml_InvalidSurrogateHighChar {
            get {
                return ResourceManager.GetString("Xml_InvalidSurrogateHighChar", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The surrogate pair is invalid. Missing a low surrogate character..
        /// </summary>
        public static string Xml_InvalidSurrogateMissingLowChar {
            get {
                return ResourceManager.GetString("Xml_InvalidSurrogateMissingLowChar", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The surrogate pair (0x{0}, 0x{1}) is invalid. A high surrogate character (0xD800 - 0xDBFF) must always be paired with a low surrogate character (0xDC00 - 0xDFFF)..
        /// </summary>
        public static string Xml_InvalidSurrogatePairWithArgs {
            get {
                return ResourceManager.GetString("Xml_InvalidSurrogatePairWithArgs", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &apos;{0}&apos; is an invalid xml:space value..
        /// </summary>
        public static string Xml_InvalidXmlSpace {
            get {
                return ResourceManager.GetString("Xml_InvalidXmlSpace", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Cannot set the namespace if Namespaces is &apos;false&apos;..
        /// </summary>
        public static string Xml_NoNamespaces {
            get {
                return ResourceManager.GetString("Xml_NoNamespaces", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Only white space characters should be used..
        /// </summary>
        public static string Xml_NonWhitespace {
            get {
                return ResourceManager.GetString("Xml_NonWhitespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Document does not have a root element..
        /// </summary>
        public static string Xml_NoRoot {
            get {
                return ResourceManager.GetString("Xml_NoRoot", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to There was no XML start tag open..
        /// </summary>
        public static string Xml_NoStartTag {
            get {
                return ResourceManager.GetString("Xml_NoStartTag", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to NotInWriteState..
        /// </summary>
        public static string Xml_NotInWriteState {
            get {
                return ResourceManager.GetString("Xml_NotInWriteState", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to WriteStartDocument needs to be the first call..
        /// </summary>
        public static string Xml_NotTheFirst {
            get {
                return ResourceManager.GetString("Xml_NotTheFirst", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Resolving of external URIs was prohibited..
        /// </summary>
        public static string Xml_NullResolver {
            get {
                return ResourceManager.GetString("Xml_NullResolver", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Cannot use a prefix with an empty namespace..
        /// </summary>
        public static string Xml_PrefixForEmptyNs {
            get {
                return ResourceManager.GetString("Xml_PrefixForEmptyNs", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Relative URIs are not supported..
        /// </summary>
        public static string Xml_RelativeUriNotSupported {
            get {
                return ResourceManager.GetString("Xml_RelativeUriNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The second character surrogate pair is not in the input buffer to be written..
        /// </summary>
        public static string Xml_SurrogatePairSplit {
            get {
                return ResourceManager.GetString("Xml_SurrogatePairSplit", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Reference to undeclared parameter entity &apos;{0}&apos;..
        /// </summary>
        public static string Xml_UndeclaredParEntity {
            get {
                return ResourceManager.GetString("Xml_UndeclaredParEntity", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The &apos;{0}&apos; namespace is not defined..
        /// </summary>
        public static string Xml_UndefNamespace {
            get {
                return ResourceManager.GetString("Xml_UndefNamespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to An undefined prefix is in use..
        /// </summary>
        public static string Xml_UndefPrefix {
            get {
                return ResourceManager.GetString("Xml_UndefPrefix", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Unexpected XmlNodeType: &apos;{0}&apos;..
        /// </summary>
        public static string Xml_UnexpectedNodeType {
            get {
                return ResourceManager.GetString("Xml_UnexpectedNodeType", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Object type is not supported..
        /// </summary>
        public static string Xml_UnsupportedClass {
            get {
                return ResourceManager.GetString("Xml_UnsupportedClass", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to XmlResolver can be set only by fully trusted code..
        /// </summary>
        public static string Xml_UntrustedCodeSettingResolver {
            get {
                return ResourceManager.GetString("Xml_UntrustedCodeSettingResolver", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Token {0} in state {1} would result in an invalid XML document..
        /// </summary>
        public static string Xml_WrongToken {
            get {
                return ResourceManager.GetString("Xml_WrongToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The &apos;xmlns&apos; attribute is bound to the reserved namespace &apos;http://www.w3.org/2000/xmlns/&apos;..
        /// </summary>
        public static string Xml_XmlnsBelongsToReservedNs {
            get {
                return ResourceManager.GetString("Xml_XmlnsBelongsToReservedNs", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The string &apos;{0}&apos; is not a valid {1} value..
        /// </summary>
        public static string XmlConvert_BadFormat {
            get {
                return ResourceManager.GetString("XmlConvert_BadFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Non-CLS Compliant Exception..
        /// </summary>
        public static string XmlNonCLSCompliantException {
            get {
                return ResourceManager.GetString("XmlNonCLSCompliantException", resourceCulture);
            }
        }
    }
}
