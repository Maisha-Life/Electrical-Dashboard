   M S B A M L   `   `   `  ���� H  DEDHarnessScan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:EDHarnessScan.ViewsEDHarnessScan.Views  2    ,EDHarnessScan.Views.ToolsScanInformationView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     3local!clr-namespace:EDHarnessScan.Views     .���   � 	Resources   �� 
TargetType   customToggleButtonLarge �� BasedOn �� Property �� Value �� Triggers �� Binding �� Value��%�   'd�       7   '� <     �� " d�8   .���  � {� �� *toolsMethodBool+�� " �.���  � {� .   ��  �� *harnessScanSelectionReadyBool+	 false.a���  � {� . .+��� $��2,5,0,0q�.+�� $��0,0,5,10q�.+��� $��20��$��0,0,5,0q��� $��Tools Scan Information��$��16(�$��Normal"��� $��1��$��Tool Scan Options��$��14(�$��1q�$��3,3,5,3q�  ��%_   '��       �� " ��.���  � ��$ 12(���  � ��$ Normal"���  � ��
 �   �.��]� $��5q���.  .+��� $	��Top=�$
��Thin"�$
��Wrap=��� $�Selecting the�� �� $�MANUAL��$��Normal"� �� $H�Boption will allow you to manually select what tools have been run.��� $	��Top=�$��	0,10,0,10q�.+�d� $��50��$��20��#��[   d� 	IsChecked �� *toolsMethodBool+�� $��MANUAL Select��$
��10,0q�]� ��.  $	��Top=�.+��� $-��'/Resources/Images/Rulez/errorStatus.png��$��16��$��0,3,2,3q��� $=��7The user will be responsible if this option is selected��$
��Thin"�$��10(�$
��Wrap=��� 	 � ToolTip$ 	 Run an automatic tool scan��$��Bottom=�$��0,10,0,0q����� *AutoToolScanCommand+.��� .+��� $0��*/EDS;component/Resources/Images/runcmd.png��$��20���� $��Run Tool Scan��$��Center=�$	��5,0q�$
��Thin"�$��12(��� $��2,10,0,0q�.+�� 
 � ColumnDefinitions
 �� $
��Auto ��� $
��Auto ��� .+��� $
��Left=�  ��%  '��       '�� i     �� " ��.���  � ��$ 18(���  � ��$ 75����  � ��
 �   ���  � ��$
 Thin"��� " ��.���  � ��$ 16����  � ��$ 2q���  �@��EdgeMode$ Aliased=���  �@��BitmapScalingMode$ NearestNeighbor=�.+�d� $��50��$��20�� �� *	PMIBool+d� $��50��$��20��$	��0,5q� �� *
DTSyncBool+d� $��50��$��20�� �� *
FFA2Bool+d� $��50��$��20��$	��0,5q� �� *RenamingBool+d� $��50��$��20�� �� *
CouponBool+�� $��1��$
��15,0q�  ��%  '��       '� �     '�� �     �� " ��.���  � ��$ 13(���  � ��$
 Thin"���  � ��
 �   ���  � ��$ 20����  � ��$ Center=��� " �.���  � ��$ 20���� " ��.���  � ��$ 20����  � ��$ 0,0,10,0q�.+��� $	��PMI���� $��DT Sync��$	��0,5q��� $
��FFA2���� $��Rename��$	��0,5q��� $��Coupon���� $��2��$
��Left=�$��15,0,0,0q�    customButtonWithContent��%�   '��       7  �� " ��8   .���  � ��$ 20����  �@��EdgeMode$ Aliased=���  �@��BitmapScalingMode$ NearestNeighbor=�.+��� .���� $0��*/EDS;component/Resources/Images/runcmd.png���� $	��0,5q�.���� $0��*/EDS;component/Resources/Images/runcmd.png���� .���� $0��*/EDS;component/Resources/Images/runcmd.png���� $	��0,5q�.���� $0��*/EDS;component/Resources/Images/runcmd.png���� .���� $0��*/EDS;component/Resources/Images/runcmd.png��