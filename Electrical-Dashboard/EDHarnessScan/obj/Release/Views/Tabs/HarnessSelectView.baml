   M S B A M L   `   `   `  ���� H  DEDHarnessScan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:EDHarnessScan.ViewsEDHarnessScan.Views  @ <EDDLL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null8(clr-namespace:EDDLL.Views;assembly=EDDLLEDDLL.Views +    %EDHarnessScan.Views.HarnessSelectView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:EDHarnessScan.Views     CcustomControls(clr-namespace:EDDLL.Views;assembly=EDDLL     .��� $��5q�  � RowDefinitions  �� $��55 ��� .+�]� ��.  $��5q�$	��Top=�.+�]� $��Center=�$	��165��.+��� $J��D/EDHarnessScan;component/Resources/Images/harnessRepositoryLarge.png��$��32��$��0,0,5,0q��� $��	Harnesses��$��Center=�$��22(�$��5,0,0,0q�  EDDLL.Views.SearchControl  �� $��Right=����� *TicketCreateCommand+.��� .+��� $R��L/ElectricalDashboard;component/Resources/Images/TicketIcons/createTicket.png��$��32��$��0,0,5,0q��� $��Create Ticket��$��Center=�$��17(�$	��5,0q�
���   �$
��Thin"��� $��Right=����� *CreateProgramCommand+.��� .+��� $C��=/EDHarnessScan;component/Resources/Images/Main/programAdd.png��$��32��$��0,0,5,0q��� $��Create Program��$��Center=�$��17(�$	��5,0q�
���   �$
��Thin"�� $��1�� � ColumnDefinitions �� $	��200 ��� $��2 ��� .+�� .+��� $��2,0,0,0q� � 	Resources  �� 
TargetType �� Property �� Value��%w   '��       '�� >     �� " ��.���  � ��$ 16����  � ��$ 3,0,0,0q��� " ��.���  � ��
 �   �.+��� $�� Programs Information��$��15(�$��0,0,5,10q��� $��5,0,5,5q��� $�Total Programs: ��$
��Thin"�$��13(� �� $
��Bold"���� *
TotalCount+�� $��5,0,5,5q��� $�Total Scanned Items: ��$
��Thin"�$��13(� �� $
��Bold"���� *
TotalCount+�� $�� Harnesses Information��$��15(�$��	0,10,5,10q��� $��5,0,5,5q��� $�Total Harnesses: ��$
��Thin"�$��13(� �� $
��Bold"���� *
TotalCount+�� $��5,0,5,5q��� $�Completed: ��$
��Thin"�$��13(� �� $
��Bold"���� *
TotalCount+�� $��5,0,5,5q��� $�In Progress: ��$
��Thin"�$��13(� �� $
��Bold"���� *
TotalCount+�� $�� EDS Severity��$��15(�$��	0,10,5,10q��� $��5,0,5,5q��� $�Total Scanned Items: ��$
��Thin"�$��13(� �� $
��Bold"���� *
TotalCount+�     statText �� BasedOn  statProgBar��%:   '��       7   '�      7  �� " ��8   �� " �8    �� $��75 ��� .+��� $��5,5,0,5q�.+��� $��Errors:���� $��	Warnings:��$	��0,1q��� $��Good:���� $��1��$	��0,6q�.+�� ���	#66E07272  
ErrorColor#���   � Value �� *
ErrorCount+� ���	#66E0B700  WarningColor#���  $	��0,5q� �� *WarningCount+� ���	#6678E072  	GoodColor#���   �� *	GoodCount+�� $��1��  DefaultBorder#��[ $��0,0,0,5q��� $��2��$
��15,0q�.+�� $��1�� �� .+��� $��2��$
��15,0q�.+�� .+��� $D��>/EDHarnessScan;component/Resources/Images/Main/programWait.png��$��28��$��0,0,5,0q��� $��	Programs:��$��20(�$
��Thin"�� $��10,15,10,15q�.+���   programItem#���  ��.  �� AlternationCount$ 2������ *
Programs+�� $��Center=�$��12(�#��[ $Q��K- no programs(s) created, once programs are made they will be listed here -������ " ��.���  � y�$ Hidden=�	 �� Triggers	 �� 
 �� Binding
 �� *Programs.Count+ �� Value 0.a���  � y�$ Visible=�� .+��� $D��>/EDHarnessScan;component/Resources/Images/Main/harnessWait.png��$��28��$��0,0,5,0q��� $��
Harnesses:��$��20(�$
��Thin"�� $��10,15,10,15q�.+���   harnessItem#���  ��. $ 2������ *HarnessesList+�� $��Center=�$��12(�#��[ $S��M- no harnesses(s) created, once harnesses are made they will be listed here -������ " ��.���  � y�$ Hidden=�	 �� 
 �� *HarnessesList.Count+ 0.a���  � y�$ Visible=�� .+��� $T��N/ElectricalDashboard;component/Resources/Images/TicketIcons/ticketAssigned.png��$��28��$��0,0,5,0q��� $��Assigned Tickets:��$��20(�$
��Thin"�� $��10,15,10,15q�.+��� ���� *TicketsAssigned+�� $��Center=�$��12(�#��[ $U��O- no ticket(s) assigned, once you have ticket(s) assigned it will appear here -������ " ��.���  � y�$ Visible=�	 �� 
 �� *TicketsAssigned.Count+ 0.a���  � y�$ Visible=�