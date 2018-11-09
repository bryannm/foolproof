﻿
namespace Foolproof.Core
{
  public class RequiredIfTrueAttribute : RequiredIfAttribute
  {
    public RequiredIfTrueAttribute(string dependentProperty) : base(dependentProperty, Operator.EqualTo, true) { }
  }
}
