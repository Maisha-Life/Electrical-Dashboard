   M S B A M L   `   `   `  ���� B  >EDRules, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:EDS.Views.ModulesEDS.Views.Modules  (    "EDS.Views.Modules.RequiredInfoView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     1localclr-namespace:EDS.Views.Modules     .���� $��Required Information��.���� $��5q�.+��   � ColumnDefinitions  �� �� .+��� .+��� $��Design Rule���� -    ��Name$ designRuleTB������ *
DesignRule+ �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=��� $��13������  �� ElementName$ designRuleTB�� �� Path$% (Validation.Errors).CurrentItem��� $��1��$��5,0,0,0q�.+��� $��	Legacy ID���� -   $ 
legacyIDTB������ *LegacyIDDesc+ . $ PropertyChanged=��� $��13������ $ 
legacyIDTB��$% (Validation.Errors).CurrentItem��� $��	Rule Name���� -   $ 
ruleNameTB��$��35�� �� TextWrapping$
 Wrap=����� *
RuleName+ . $ PropertyChanged=��� $��13������ $ 
ruleNameTB��$% (Validation.Errors).CurrentItem��� $��Rule Description���� -   $ ruleDescriptionTB��$��35��$
��Auto��$
 Wrap=� �� AcceptsReturn . ���� *
RuleDesc+ . $ PropertyChanged=��� $��13������ $ ruleDescriptionTB��$% (Validation.Errors).CurrentItem�