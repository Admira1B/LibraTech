   M S B A M L   `   `   `  ���� D  @LibraTech, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:LibraTech	LibraTech      LibraTech.App   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     )localclr-namespace:LibraTech       �� 	Resources     
menuButton �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Triggers P� Property P� Value  TextBox.Static.Border	 �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border  FocusVisual
 �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background  Button.Static.Border  Button.MouseOver.Background �� 
ResourceId �� TypeInTargetAssembly&   System.Windows.Controls.DataGrid ��Name �Name J� Opacity � Points �� Stretch �� Triggers �� 
TargetName  DataGridColumnHeader=  7System.Windows.Controls.Primitives.DataGridColumnHeader 	 DataGrid:  4System.Windows.Controls.Primitives.DataGridRowHeader 
 DataGridScrollBar  MainDataGridStyle �� Padding ��Name � ColumnDefinitions � RowDefinitions   SelectAllCommand7  1System.Windows.Controls.DataGridHeadersVisibility
   All �� ConverterParameter!   HeadersVisibilityConverter �� 	Converter �� RelativeSource �� AncestorTypeG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter   Name!   Column" ��Name# �� CanContentScroll$ ��Name% �� ScrollableHeight& � Maximum' �� Orientation( �� ViewportHeight) �� ViewportSize** �� #ComputedVerticalScrollBarVisibility+ � Value, �� Mode- �� ScrollableWidth. �� ViewportWidth,/ �� %ComputedHorizontalScrollBarVisibility0 ]� 
Conditions1 �� Property2 �� Value  Button.MouseOver.Border  Button.Pressed.Background  FocusVisual2  Button.Static.Background2  Button.Static.Border2   Button.MouseOver.Background2  Button.MouseOver.Border2  Button.Pressed.Background2  Button.Pressed.Border2  Button.Disabled.Background2  Button.Disabled.Border2  Button.Disabled.Foreground2  ButtonStyleMain3 ��Name4 ��Name  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border  Button.Disabled.Foreground  FocusVisual1  Button.Static.Background1  Button.Static.Border1    Button.MouseOver.Background1 ! Button.MouseOver.Border1 " Button.Pressed.Background1 # Button.Pressed.Border1 $ Button.Disabled.Background1 % Button.Disabled.Border1 & Button.Disabled.Foreground1 ' ConfirmButton ( RoundedButton ) InputTextBox-  'System.Windows.Input.KeyboardNavigation * TextBox.Static.Border1 + TextBox.MouseOver.Border1 , TextBox.Focus.Border1 - PasswordBoxStyle��%�  &	        &	     &	     &	 -    &	 B    &	 �    &	 �    &	 �    (�� �    $" DataGridSelectAllButtonStyle��"  )&	 s    &		 �    &	
 g    &	 �    &	 �
    &	 �
    &	 �
    &	     &	     &	 ,    &	 A    &	 V    &	 k    &	 �    &	 �    &	 �    &	 �    7  7  7  7  7  7  7  7  7  7  &	 �    &	 �    &	 �    &	 �    &	     &	 c    &	 x    &	  �    &	! �    &	" �    &	# �    &	$ �    &	% �    &	&     &	'      7  7  7  7   7 ! 7 " 7 # 7 $ 7 % 7 & &	(     7  7  7  7  7  7  7  7  7  7  &	)     7  &	* �    &	+ �    &	, �    &	- �    7 * 7 + 7 , �� " 	�.���  � ��
 ���� ��  � �� �� " 	�.R��� #��z��$ 8��._��� $
��Left=�$��Center=� P�  �@J�IsMouseOver$
 True��. ���  � �� �	#FFE0E0E0P�  �@d�	IsChecked$
 TrueY�. ���  � �� �	#FFE0E0E0�� $	 	#FFABAdB3���� $	 	#FF7EB4EA���� $	 	#FF569DE5���� .���  � �� �� .R��� $��2q�$	
 1 2R�#��� ��$
 true��$��1���� $	 	#FFDDDDDD���� $	 	#FF707070���� $	 	#FFBEE6FD���� " ��.���  � �� �� " ��.R�� .+��� $ Border��#��� ��$
 True��� $ Arrow��
���   �$��Right=�$��8,8,3,3q�$
 0.15Q� �   ��� ��� ��� ��� $ Uniform=�$��Bottom=� P�  �@J�IsMouseOver$
 True��. ��� $ Border��# � �� � ��P�  � ��$
 True��. ��� $ Border��# � �� � ��P�  � {�$ False��. ��� $ Arrow�� � y�$ 	Collapsed=��� "  .���  � �� �	#FFC8C9CF��  � �� �� "  .R��� $ 6��#��z��._��� $��Center=�$
��Left=��� "  .���  � ��
 ���� ��  � �� �� "  .R��� $ 6��#��z��._��� $��Center=�$
��Left=��� " ��.���  � ��
 ���� ��  � �� �� " ��.R��� $ 0,0,6,6��._��� $��Center=�$
��Left=��� "  .���  � ��
 ���� ��  � ��# � ����  � �� �	#FFC8C9CF��  � ��$ 1q���   �@ RowDetailsVisibilityMode$ VisibleWhenSelected=���  � ��$
 true����  �@��PanningMode$
 Both=���  �@��IsFlicksEnabled$ False����  � �� �� "  .R��� $ 13��#��z��#��z��#��z��# z��$
 True��._��� $ DG_ScrollViewer��$|�false������ " ��.R��  �� $
��Auto ��� $��* ��� $
��Auto � �� $
��Auto ��� $��* ��� $
��Auto �.+��� #��Z $|�false����C� *�� $" DataGridSelectAllButtonStyle��"  +y��� *HeadersVisibility+# Z # Z  �� "  ���� *CellsPanelHorizontalOffset+ �� "    $!  PART_ColumnHeadersPresenter��$��1��y��� *HeadersVisibility+# Z! # Z  �� "  �� $!" PART_ScrollContentPresenter��## z��$��2��$��1���� $$ PART_VerticalScrollBar��$��2��#& z% $' Vertical=�$��1��#) z( #y�z* + �� *VerticalOffset+$, OneWay=� �� *TemplatedParent+� $��1��$��2�� �� ���� **(NonFrozenColumnsViewportHorizontalOffset+ �� "  �� $��* �.+��� $$ PART_HorizontalScrollBar��$��1��#& z- $' 
Horizontal=�#) z. #y�z/ + �� *HorizontalOffset+$, OneWay=� �� *TemplatedParent+.���� # z  ]� 0 �� 1 �@��
IsGrouping$
2 true���� "1 �@%�IsVirtualizingWhenGrouping$2 false��./���  � ��$ false���� $	 	#FF3C7FB1���� $	 	#FFC4E5F6���� .���  � �� �� .R��� $��2q�$	
 1 2R�#��� ��$
 true��$��1���� $	 	#FFE0E0E0���� $	 	#FFE0E0E0���� $	 	#FFBEE6FD���� $	 	#FF3C7FB1���� $	 	#FFC4E5F6���� $	 	#FF2C628B���� $	 	#FFF4F4F4���� $	 	#FFE0E0E0���� $	 	#FFE0E0E0���� " ��.���  �@�FocusVisualStyle8   ��  � ��8  ��  � ��8  ��  � ��# � ����  � ��$ 1q���  � ��$ Center=���  � ��$ Center=���  � ��$ 1q���  � �� �� " ��.R��� $3 border��$ 15��#��z��#��z��#��z��$
 true��._��� $4 contentPresenter��$|�False��#��z��#��z��$
��True��# z #��z�� P�  �@��IsDefaulted$
 true��. ��� $ border��# � �� � ��P�  �@J�IsMouseOver$
 true��. ��� $ border��8   � ���� $ border��8   � ��P�  � ��$
 true��. ��� $ border��8   � ���� $ border��8   � ��P�  � {�$ false��. ��� $ border��8   � ���� $ border��8   � ���� $ contentPresenter��8 	  � ���� $	 	#FF2C628B���� $	 	#FFF4F4F4���� $	 	#FFADB2B5���� $	 	#FF838383���� .���  � �� �� .R��� $��2q�$	
 1 2R�#��� ��$
 true��$��1���� $	 	#FFDDDDDD���� $	 	#FF707070���� $	 	#FFBEE6FD���� $	 	#FF3C7FB1���� $	 	#FFC4E5F6���� $	 	#FF2C628B���� $	 	#FFF4F4F4���� $	 	#FFADB2B5���� $	 	#FF838383���� " ��.���  �@�FocusVisualStyle8   ��  � ��8  ��  � ��8  ��  � ��# � ����  � ��$ 1q���  � ��$ Center=���  � ��$ Center=���  � ��$ 1q���  � �� �� " ��.R��� $3 border��$ 13��#��z��#��z��#��z��$
 true��._��� $4 contentPresenter��$|�False��#��z��#��z��$
��True��# z #��z�� P�  �@��IsDefaulted$
 true��. ��� $ border��# � �� � ��P�  �@J�IsMouseOver$
 true��. ��� $ border��8   � ���� $ border��8   � ��P�  � ��$
 true��. ��� $ border��8   � ���� $ border��8   � ��P�  � {�$ false��. ��� $ border��8   � ���� $ border��8   � ���� $ contentPresenter��8 	  � ���� " ��.���  �@�FocusVisualStyle8   ��  � ��8  ��  � ��8  ��  � ��# � ����  � ��$ 1q���  � ��$ Center=���  � ��$ Center=���  � ��$ 1q���  � �� �� " ��.R��� $3 border��$ 13��#��z��#��z��#��z��$
 true��._��� $4 contentPresenter��$|�False��#��z��#��z��$
��True��# z #��z�� P�  �@��IsDefaulted$
 true��. ��� $ border��# � �� � ��P�  �@J�IsMouseOver$
 true��. ��� $ border��8   � ���� $ border��8   � ��P�  � ��$
 true��. ��� $ border��8   � ���� $ border��8   � ��P�  � {�$ false��. ��� $ border��8   � ���� $ border��8   � ���� $ contentPresenter��8 	  � ���� " ��.���  � ��# � ����  � ��8   ��  � ��# � ����  � ��$ 1q���  �@ TabNavigation$
 None=���  � ��$
 Left=���  �@�FocusVisualStyle Z� ��  �@J�	AllowDrop$
 true����  �@��PanningMode$ VerticalFirst=���  �@��IsFlicksEnabled$ False����  � �� �� " ��.R��� $3 border��$ 13��#��z��#��z��#��z��$
 True��._��� $ PART_ContentHost��$|�false��$��Hidden=�$��Hidden=� P�  � {�$ false��. ��� $ border�� �@J�Opacity$
 0.56Q�P�  �@J�IsMouseOver$
 true��. ��� $ border�� � �� �	#FFE0E0E0P�  �@J�IsKeyboardFocused$
 true��. ��� $ border�� � �� �	#FFE0E0E0 ]� 0 �� +1 �@��#IsInactiveSelectionHighlightEnabled$
2 true���� 1 �@��IsSelectionActive$2 false��./���  �@��SelectionBrush# � /��� $	 	#FFABAdB3���� $	 	#FF7EB4EA���� $	 	#FF569DE5���� " G�.���  �@G�PasswordChar$	 ●����  � ��# � ����  � ��8   ��  � ��# � ����  � ��$ 1q���  �@ TabNavigation$
 None=���  � ��$
 Left=���  �@�FocusVisualStyle Z� ��  �@J�	AllowDrop$
 true����  �@��PanningMode$ VerticalFirst=���  �@��IsFlicksEnabled$ False����  � �� �� " G�.R��� $3 border��#��z��#��z��#��z��$
 True��$ 13��._��� $ PART_ContentHost��$|�false��$��Hidden=�$��Hidden=� P�  � {�$ false��. ��� $ border�� �@J�Opacity$
 0.56Q�P�  �@J�IsMouseOver$
 true��. ��� $ border��8   � ��P�  �@J�IsKeyboardFocused$
 true��. ��� $ border��8   � �� ]� 0 �� +1 �@G�#IsInactiveSelectionHighlightEnabled$
2 true���� 1 �@G�IsSelectionActive$2 false��./���  �@G�SelectionBrush# � /�