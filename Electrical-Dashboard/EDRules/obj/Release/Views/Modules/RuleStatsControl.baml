   M S B A M L   `   `   `  ���� B  >EDRules, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:EDRules.Views.RuleEDRules.Views.Rule  )    #EDRules.Views.Rule.RuleStatsControl   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     2local clr-namespace:EDRules.Views.Rule     .���   � RowDefinitions  �� $	��350 ��� .+��� $��2,0,0,0q� � 	Resources  �� 
TargetType �� Property �� Value��%w   '��       '�� >     �� " ��.���  � ��$ 16����  � ��$ 3,0,0,0q��� " ��.���  � ��
 �   �.+��� -    ��Name$ 	StatusKey��.+��� $�� Rule Information��$��15(�$��0,0,5,10q�� .+��� $=��7/EDDLL;component/Resources/Images/Status/goodStatus.png���� $�� - Good ��$
��Thin"�$��13(�$��Center=�� .+��� $@��:/EDDLL;component/Resources/Images/Status/warningStatus.png���� $
��Thin"�$��13(�$��Center=��� $�
 - Warning��� .+��� $>��8/EDDLL;component/Resources/Images/Status/errorStatus.png���� $
��Thin"�$��13(�$��Center=��� $� - Error���� -   $ ItemsCharts��.+��� $��	 Severity��$��15(�$��	0,35,5,10q��� $��5,0,5,5q��� $�Total Rules Count Items: ��$
��Thin"�$��13(� �� $
��Bold"���� *TotalRuleCount+�     statText �� BasedOn  statProgBar �� RelativeSource �� Path��%�   '��       7   '�      7  �� " ��8   �� " �8   .���  �@�ToolTip ��  �� *Self+$ Value���  �@�Maximum �� *TotalRuleCount+	 � ColumnDefinitions	 �� $��75 ��� .+��� $��5,5,0,5q�.+��� $��Errors:���� $��	Warnings:��$	��0,1q��� $��Good:���� $��
Questions:��$��0,15,0,0q��� $��Constraints:��$��0,1,0,0q��� $��Checks:��$	��0,1q��� $��Repairs:���� $��1��$	��0,6q�.+�� ���	#66E07272  
ErrorColor#��[ 
 � Value
 �� *TotalErrorCount+� ���	#66E0B700  WarningColor#��[ $	��0,5q�
 �� *TotalWarningCount+� ���	#6678E072  	GoodColor#��[ 
 �� *TotalGoodCount+� ���	#664A4A4A  DefaultBorder#��[ $��0,20,0,0q�
 �� *TotalAnswerCount+ � Maximum �� *TotalQuestionCount+� ���	#664A4A4A#��[ $��0,5,0,0q�
 �� *TotalErrorCount+� ���	#664A4A4A#��[ $	��0,5q�
 �� *TotalErrorCount+� ���	#664A4A4A#��[ 
 �� *TotalErrorCount+