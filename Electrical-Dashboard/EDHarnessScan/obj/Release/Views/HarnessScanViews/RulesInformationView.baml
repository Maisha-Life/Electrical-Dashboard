   M S B A M L   `   `   `  ���� H  DEDHarnessScan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:EDHarnessScan.ViewsEDHarnessScan.Views  O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem @ <EDDLL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null8(clr-namespace:EDDLL.Views;assembly=EDDLLEDDLL.Views .    (EDHarnessScan.Views.RulesInformationView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:EDHarnessScan.Views     6sys&clr-namespace:System;assembly=mscorlib     CcustomControls(clr-namespace:EDDLL.Views;assembly=EDDLL     .���   � RowDefinitions  �� $��55 ��� .+�]� $��1,5,5,5q���.  $	��Top=�.+�� $��0,4,0,0q�.+�  EDDLL.Views.SearchControl  �� $��
filter.png��$��24��$��20,0,0,0q��� $��Filter��$��Center=�$��17(�$��0,0,5,0q�
���   �$
��Thin"��� $��20��$	��150�� �� 
IsReadOnly .  �� 
IsEditable . {�.   �� SelectedItem �� *selectedFilter+ �� UpdateSourceTrigger$ PropertyChanged=����� *filtersList+ �� SelectedIndex �� *selectedFilterIndex+$ PropertyChanged=�� $��1�� � ColumnDefinitions .+�� -    �Name$ 	rulesList��$��2��  �� $��25 ��� .+��  � 	Resources 	 �� 
TargetType
 �� Property �� Value   DefaultBorder��%�   '��       7   �� "	 ��.��� 
 � ��$ 15(��� 
 � ��$
 Thin"��� 
 � ��8   �� 
 � ��$ Center=��� 
 � ��$
 Left=� �� $��37 ��� $	��125 ��� $��80 ��� $	��200 ��� �� $	��255 ��� $	��250 �.+��� $��mood.png��$��3q� � ToolTip$ Current State���� $��1��$�� Design Rule���� $��2��$�� Type���� $��3��$��
 Rule Name���� $��4��$�� Description���� $��5��$��Check���� $��6��$��Repair��]� $��2��.+��� $��5,6,7,2q�$	��Top=�$��2��#��[   �� RadiusX$ 0���� -   $
��Auto=�$��5q�$��2��   VerticalScrollBar��%s   (��       *,*SystemParameters.VerticalScrollBarWidthKey+)'��      7  X�12Q��� "	 ��.��� 
 � ��8   .����   harnessRuleItem#��[  �� AlternationCount$ 2������ *HarnessRules+� $��2��  �� Triggers �� Binding �� Value��%�   '�       �� "	 �.��� 
 � y�$ Hidden=� ��  �� *harnessScanSelectionReadyBool+	 false.a��� 
 � y�$ Visible=�.+���  J� Opacity$ .7Q�$ 5�� �� RadiusY$ 5��$��2,0,0,0q�   WarningColor��%�   '��       7  �� "	 ��.��� 
 � �� �	#FF8D8D8D ��  �� *toolsScanCompleteTerniary+ 0.a��� 
 � ��8   � $��Center=�$��Center=�$	��450��   customButtonWithContent �� BasedOn��%�   '�       '�� {     7  �� "	 �.��� 
 � y�$ Visible=� ��  �� *toolsScanCompleteTerniary+ 0.a��� 
 � y�$ Hidden=��� "	 ��8   .+��� 
�������$ .8Q�$��2���� $��15q�.+�� $��0,0,0,10q�.+��� $��law.png��$��25���� $�� Tool Scan Not Complete! ��$��Normal"�$��15(�$
��Wrap=��� $L��FTool Scan required to be complete in order to start the harness scan. ��$
��Thin"�$��15(�$
��Wrap=��� $
��Thin"�$��14(�$
��Wrap=��� �� $�· Run�� �� $
�SCAN��$��Normal"� �� $\�Vif the tools have been run inside the given harness, otherwise run the required tools.���� �� $�· Run�� �� $�MANUAL��$��Normal"� �� $Q�Kif the tools have been run and you would like to select the tools your self��� $��Center=�$��Center=�$��25q�$��2�� ��%�   '�       '�� �     7  �� "	 �.��� 
 � y�$ Hidden=� ��  �� *toolsScanCompleteTerniary+ 0.a��� 
 � y�$ Visible=���  �� *harnessScanSelectionReadyBool+ true.a��� 
 � y�$ Hidden=��� "	 ��8     �� $	��150 ��� .+��� 
�������$ .8Q�$��2���� $��15q�.+��� $?��9Select what rules you would like to run on this harness. ��$
��Thin"�$��15(�$
��Wrap=��� $
��Thin"�$��14(�$
��Wrap=��� �� $�	· Select�� �� $	�all��$��Normal"� �� $1�+if all rules need to be run on this harness���� �� $�	· Select�� �� $�specific��$��Normal"� �� $*�$rules if there are only a few needed���� � $��1��$��Center=�$��0,0,0,10q�.+��� $ continue...������ *ContinueRuleSelectionCommand+.��� .+��� $��law.png��$��25���� $��Continue��$��Center=�$	��5,0q�$
��Thin"�$��15(�