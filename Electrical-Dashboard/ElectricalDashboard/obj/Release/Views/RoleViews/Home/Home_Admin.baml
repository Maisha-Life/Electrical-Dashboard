   M S B A M L   `   `   `  ���� @  <EDDLL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null8(clr-namespace:EDDLL.Views;assembly=EDDLLEDDLL.Views  N JElectricalDashboard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:ElectricalDashboard.Views.RoleViews.Home(ElectricalDashboard.Views.RoleViews.Home O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem U/clr-namespace:ElectricalDashboard.Views.Tickets!ElectricalDashboard.Views.Tickets B >EDTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullP5clr-namespace:EDTools.Views.SubViews;assembly=EDToolsEDTools.Views.SubViews B >EDRules, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullH1clr-namespace:EDRules.Views.Rule;assembly=EDRulesEDRules.Views.Rule <*clr-namespace:EDDLL.Tickets;assembly=EDDLLEDDLL.Tickets  9   3ElectricalDashboard.Views.RoleViews.Home.Home_Admin   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     CcustomControls(clr-namespace:EDDLL.Views;assembly=EDDLL     Hlocal6clr-namespace:ElectricalDashboard.Views.RoleViews.Home     6sys&clr-namespace:System;assembly=mscorlib     GticketViews/clr-namespace:ElectricalDashboard.Views.Tickets     K	toolStats5clr-namespace:EDTools.Views.SubViews;assembly=EDTools     G	ruleStats1clr-namespace:EDRules.Views.Rule;assembly=EDRules     KstaticCreatedTickets*clr-namespace:EDDLL.Tickets;assembly=EDDLL     .��� $��5q�  � RowDefinitions  �� .+�� $��1�� � ColumnDefinitions �� �� $��2 ��� $	��250 �.+��� .+��� -    ��Name$ ticketsOverview��$��15q�.+�� .+��� $T��N/ElectricalDashboard;component/Resources/Images/TicketIcons/ticketAssigned.png��$��28��$��0,0,5,0q��� $��Assigned Tickets:��$��20(�$
��Thin"�� $��10,15,10,15q�.+���    ticketListItem#��[  ����  �� Path$6 0(staticCreatedTickets:TicketsVM.TicketsAssigned)��� $��Center=�$��12(�  WarningColor#��[ $U��O- no ticket(s) assigned, once you have ticket(s) assigned it will appear here -������  �� 
TargetType" ��.���  �� Property � y� �� Value$ 	Collapsed=� �� Triggers ��  �� Binding �� $< 6(staticCreatedTickets:TicketsVM.TicketsAssigned).Count�	 �� Value	 0.a���  � y�$ Visible=�� $��0,25,0,0q�.+��� $S��M/ElectricalDashboard;component/Resources/Images/TicketIcons/ticketCreated.png��$��28��$��0,0,5,0q��� $��Created Tickets:��$��20(�$
��Thin"�� $��10,15,10,15q�.+��� #��[  ���� $5 /(staticCreatedTickets:TicketsVM.TicketsCreated)��� $��Center=�$��12(�#��[ $U��O- no ticket(s) created, once you have created a ticket(s) it will appear here -������ " ��.���  � y�$ 	Collapsed=� ��  �� $; 5(staticCreatedTickets:TicketsVM.TicketsCreated).Count�	 0.a���  � y�$ Visible=��� -   $ toolsOverview��$��15q�.+�� $��0,0,0,15q�.+��� $7��1/EDTools;component/Resources/Images/toolLarge.png��$��28��$��0,0,5,0q��� $��
Top Tools:��$��20(�$
��Thin"���   toolGridItemScalable#��[ ���� *TopToolsList+���� .R��� 
 �� Orientation$
 
Horizontal=�$��Stretch=��� $��1��  DefaultBorder#��[ $��0,0,0,5q�� $��2��.+��� -   $
��Auto=�$	��0,5q� � 	Resources   VerticalScrollBar��%s   (��       *,*SystemParameters.VerticalScrollBarWidthKey+)'��      7  X�12Q��� " ��.���  � ��8   .���� $
��15,0q�.+�7  1ElectricalDashboard.Views.Tickets.TicketStatsView  -     Name$ ticketStats��-  'EDTools.Views.SubViews.ToolStatsControl  -     Name$ 	toolStats��$
��0,15q�)  #EDRules.Views.Rule.RuleStatsControl  -     Name$ 	ruleStats��� .+��� $��2,0,0,0q� ��%w   '��       '�� >     �� " ��.���  � ��$ 16����  � ��$ 3,0,0,0q��� " ��.���  � ��
 �   �.+��� $�� Programs Information��$��15(�$��0,0,5,10q��� $��5,0,5,5q��� $�Total Programs: ��$
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
TotalCount+�    statText �� BasedOn  statProgBar��%:   '��       7  '�      7  �� " ��8   �� " �8    �� $��75 ��� .+��� $��5,5,0,5q�.+��� $��Errors:���� $��	Warnings:��$	��0,1q��� $��Good:���� $��1��$	��0,6q�.+�� ���	#66E07272  
ErrorColor#���   � Value �� *
ErrorCount+� ���	#66E0B700#���  $	��0,5q� �� *WarningCount+� ���	#6678E072  	GoodColor#���   �� *	GoodCount+