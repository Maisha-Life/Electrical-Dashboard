   M S B A M L   `   `   `  ���� N  JElectricalDashboard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ElectricalDashboard.ViewsElectricalDashboard.Views  8    2ElectricalDashboard.Views.TicketViews.TicketCVMain   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     9local'clr-namespace:ElectricalDashboard.Views     .���� $��2q�   DefaultBorder#��[  ._�� $��5q�  � RowDefinitions  �� $��30 ��� .+�]� ��.  .+�� $��Center=�.+��� $��22��$��0,0,5,0q� � 	Resources  �� 
TargetType �� Property �� Value �� Triggers �� Binding �� Value��%�  '��       �� " ��.���  � ��$D >/EDDLL;component/Resources/Images/TicketIcons/assignTicket.png�� ��  �� *
TicketType+ Tool.a���  � ��$O I/ElectricalDashboard;component/Resources/Images/TicketIcons/icon_tool.png����  �� *
TicketType+ Rule.a���  � ��$O I/ElectricalDashboard;component/Resources/Images/TicketIcons/icon_rule.png����  �� *
TicketType+	 Other.a���  � ��$P J/ElectricalDashboard;component/Resources/Images/TicketIcons/icon_other.png����  �� *
TicketType+ Program.a���  � ��$R L/ElectricalDashboard;component/Resources/Images/TicketIcons/icon_program.png����  �� *
TicketType+ Harness.a���  � ��$R L/ElectricalDashboard;component/Resources/Images/TicketIcons/icon_harness.png����  �� *
TicketType+ HarnessCheck.a���  � ��$W Q/ElectricalDashboard;component/Resources/Images/TicketIcons/icon_harnessCheck.png���� $��Center=�$��17(�$��0,0,20,0q�
���   �$
��Thin"� ��%D  '��       �� " ��.���  � ��$" Select Ticket Type to Create�� ��  �� *
TicketType+ Tool.a���  � ��$ Create Tool Ticket����  �� *
TicketType+ Rule.a���  � ��$ Create Rule Ticket����  �� *
TicketType+	 Other.a���  � ��$ Create Other Ticket����  �� *
TicketType+ Program.a���  � ��$ Create Program Ticket����  �� *
TicketType+ Harness.a���  � ��$ Create Harness Ticket����  �� *
TicketType+ HarnessCheck.a���  � ��$! Create Harness Check Ticket���� $��Right=����� *CancelCreateCommand+.���� $1��+/EDDLL;component/Resources/Images/close.png��� $��1��$��Center=�$��Center=�   customButtonWithContent �� BasedOn��%�  '�       '�� s     7  '�� �     '�� �     �� " �.���  � y�$ Visible=� ��  �� *TypeSelectBool+ True.a���  � y�$ Hidden=��� " ��8   .���  � ��$	 0,5q��� " ��.���  � ��$ 23����  � ��$ 23���� " ��.���  � ��$ 5,0,0,0q���  � ��$ Center=���  � ��$ 15(���  � ��$
 Thin"���  � ��$	 100��  �� $��40 ��� 	 � ColumnDefinitions	 �� �� .+��� $!��Please select a ticket type��$��2��$
��auto��$��Center=�$	��Top=�$��	-30,0,0,0q��� $��1��.+��� $
��Tool������ *SelectTicketTypeCommand+.��� .+��� $O��I/ElectricalDashboard;component/Resources/Images/TicketIcons/icon_tool.png���� $
��Tool��$��5,0,0,0q��� $
��Rule������ *SelectTicketTypeCommand+.��� .+��� $O��I/ElectricalDashboard;component/Resources/Images/TicketIcons/icon_rule.png���� $
��Rule��$��5,0,0,0q��� $��Other������ *SelectTicketTypeCommand+.��� .+��� $P��J/ElectricalDashboard;component/Resources/Images/TicketIcons/icon_other.png���� $��Other��$��5,0,0,0q��� $��1��$��1��.+��� $��Program������ *SelectTicketTypeCommand+.��� .+��� $R��L/ElectricalDashboard;component/Resources/Images/TicketIcons/icon_program.png���� $��Program��$��5,0,0,0q��� $��Harness������ *SelectTicketTypeCommand+.��� .+��� $R��L/ElectricalDashboard;component/Resources/Images/TicketIcons/icon_harness.png���� $��Harness��$��5,0,0,0q��� $��HarnessCheck������ *SelectTicketTypeCommand+.��� .+��� $W��Q/ElectricalDashboard;component/Resources/Images/TicketIcons/icon_harnessCheck.png���� $��Harness Check��$��5,0,0,0q�� $��1��$��Bottom=� ��%}   '�       �� " �.���  � y�$ Hidden=� ��  �� *TypeSelectBool+ True.a���  � y�$ Visible=�  �� �� $��40 �.+��� $��Required Information��$��0��.���� $��2q�.+�� 	 �� $
��1.5* ��� .+��� .+��� $��Assignee���� -   
 ��Name$
 
assigneeCB�� �� Text �� *
Assignee+ �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=��� $��13������  �� ElementName$ 
assigneeCB�� �� Path$% (Validation.Errors).CurrentItem��� $
��Tool���� -   $
 toolCB�� �� *Tool+ . $ PropertyChanged=��� $��13������ $ toolCB��$% (Validation.Errors).CurrentItem��� $��Category���� -   $
 
categoryCB�� �� *
Category+ . $ PropertyChanged=��� $��13������ $ 
categoryCB��$% (Validation.Errors).CurrentItem��� $��1��$��5,0,0,0q�.+��� $��Priority���� -   $
 
priorityCB�� �� *ImportanceLevel+ . $ PropertyChanged=��� $��13������ $ 
priorityCB��$% (Validation.Errors).CurrentItem��� $��Date Created��(  "System.Windows.Controls.DatePicker  -     Name$ dateCreated��{�.     SelectedDate �� *DateAssigned+ . $ PropertyChanged=��� $��13������ $ dateCreated��$% (Validation.Errors).CurrentItem��� $��Date Due��  -   $ 	dateDueDP��   DisplayDateStart$ 	2020-8-31X� �� *	DateDue+ . $ PropertyChanged=��� $��13������ $ 	dateDueDP��$% (Validation.Errors).CurrentItem�� .+��� $��Ticket Description���� $?��9	(please add any extra information related to the ticket)��$��Italic$��� -    ��Name$ descriptionTB�� �� TextWrapping$
 Wrap=�$	��150������ *Description+ . $ PropertyChanged=��� $��13������ $ descriptionTB��$% (Validation.Errors).CurrentItem�]� $��2����.  .+��� $��	Re-select��$
��Left=�$	��5,0q����� *RevertTicketCommand+�� $��Cancel��$��Right=�$	��5,0q����� *CancelCreateCommand+�� $��Create��$��Right=�$	��5,0q����� *CreateCommand+