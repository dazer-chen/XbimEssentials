// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.IfcRail.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.IfcRail.PresentationAppearanceResource;
//## Custom using statements
//##


namespace Xbim.IfcRail.PresentationAppearanceResource
{
	[ExpressType("IfcTextStyle", 427)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTextStyle : IfcPresentationStyle, IInstantiableEntity, IfcPresentationStyleSelect, IContainsEntityReferences, IEquatable<@IfcTextStyle>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextStyle(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcTextStyleForDefinedFont _textCharacterAppearance;
		private IfcTextStyleTextModel _textStyle;
		private IfcTextFontSelect _textFontStyle;
		private IfcBoolean? _modelOrDraughting;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 2)]
		public IfcTextStyleForDefinedFont @TextCharacterAppearance 
		{ 
			get 
			{
				if(_activated) return _textCharacterAppearance;
				Activate();
				return _textCharacterAppearance;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _textCharacterAppearance = v, _textCharacterAppearance, value,  "TextCharacterAppearance", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcTextStyleTextModel @TextStyle 
		{ 
			get 
			{
				if(_activated) return _textStyle;
				Activate();
				return _textStyle;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _textStyle = v, _textStyle, value,  "TextStyle", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 4)]
		public IfcTextFontSelect @TextFontStyle 
		{ 
			get 
			{
				if(_activated) return _textFontStyle;
				Activate();
				return _textFontStyle;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _textFontStyle = v, _textFontStyle, value,  "TextFontStyle", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcBoolean? @ModelOrDraughting 
		{ 
			get 
			{
				if(_activated) return _modelOrDraughting;
				Activate();
				return _modelOrDraughting;
			} 
			set
			{
				SetValue( v =>  _modelOrDraughting = v, _modelOrDraughting, value,  "ModelOrDraughting", 5);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_textCharacterAppearance = (IfcTextStyleForDefinedFont)(value.EntityVal);
					return;
				case 2: 
					_textStyle = (IfcTextStyleTextModel)(value.EntityVal);
					return;
				case 3: 
					_textFontStyle = (IfcTextFontSelect)(value.EntityVal);
					return;
				case 4: 
					_modelOrDraughting = value.BooleanVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTextStyle other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@TextCharacterAppearance != null)
					yield return @TextCharacterAppearance;
				if (@TextStyle != null)
					yield return @TextStyle;
				if (@TextFontStyle != null)
					yield return @TextFontStyle;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}