   M S B A M L   `   `   `  ����M  IAirline_Management, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Airline_ManagementAirline_Management  5      $    Airline_Management.UserWindow4   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:Airline_Management     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -   5          � Title$  User Window��5      $	��600��5	      $	��429��5
       � 
ResizeMode$ NoResize=�5      $y�Visible=�5       � WindowStyle$
 None=�5      ��5      Z� .��5      �� 
�������$	��0.3q�5   	    �� CornerRadius$ 10��5   	   ��5   
   �� 5       �� 
StartPoint$ 0.5,0&�6"    �� EndPoint$ 0.5,1&�65   .��5      �  � Offset$ 0Q�6    � Color$ 	#FFF1F7F7��6*   � 5      $ 0.317Q�6   $ 	#FF3DC3F5��6.   5      ._�5   
   � .+�5      A� -   5        $��0��5      $��15��5      $��15��5       $��
0,10,553,0q�5!      $��Right=�5"      $	��Top=�5#       � Cursor$
 Hand��5$      ���	#FFFF5F52	 J� RenderTransformOrigin$	 0.509,0.469&�5'      
 � ToolTip$

 Exit��5(      A� 5)      -   5        $��0��5*      $��15��5+      $��15��5,      $��
0,10,533,0q�5-      $��Right=�5.      $	��Top=�5/      $
 Hand��50      ���	#FFFFBE05$	 0.509,0.469&�53      $
 Minimize��54      A� 55      -   5        $��0��56      $��15��57      $��15��58      $��
0,10,512,0q�59      $��Right=�5:      $	��Top=�5;      $
 Hand��5<      ���	#FF15CC35$	 0.509,0.469&�5?      $
 Maximize��5@      �� 5A      -   5         ��Name$ main_window��5B      $��88��5C      $��20��5D      $��-34,103,0,0q�5E      $
��Left=�5F      $	��Top=�5G      ���	#FFE6EDFF$��Главное окно��5J      $
 Hand��5K      $��Franklin Gothic Demi)�5L      $	 0.5,0.5&�5M      z�5N      V� 5O      .~�5P      �� �� 5Q      �� 5R       �� Angle$ 90.392Q�6*   T� 5S      5T      5V      �� 5W      $	��153��5X      $��Center=�5Y      $	��Top=�5Z      $��Окно отчетов��5[      $��Tahoma)�5\      $��16(�5]      $
��Bold"�5^      &   System.Windows.Controls.DataGrid  5_      -   5          Name$ view_data_grid��5`      $��37,78,38,51q�5a         AlternatingRowBackground �	#FF3DC3F5$��JetBrains Mono NL)�5c      $	 0.487,0.522&�5e      ��5d      �� 5e      �� 5f      -   5        $ passenger_report��5g      $	��177��5h      $��24��5i      $��	37,54,0,0q�5j      $
��Left=�5k      $	��Top=�5l      ���	#FFE6EDFF$(��"Отчет о пассажирах��5o      $
 Hand��5p      $��Cambria Math)�5q      $	 0.496,0.529&�5r      �� 5s      -   5        $ flight_report��5t      $	��185��5u      $��24��5v      $��
376,54,0,0q�5w      $
��Left=�5x      $	��Top=�5y      ���	#FFE6EDFF$"��Отчет о полетах��5|      $
 Hand��5}      $��Cambria Math)�5~      $	 0.379,0.403&�5      �� 5�      -	   5        $ pilot_report��5�      $	��162��5�      $��24��5�      $��
214,54,0,0q�5�      $
��Left=�5�      $	��Top=�5�      ���	#FFE6EDFF$"��Отчет о пилотах��5�      $
 Hand��5�      $��Cambria Math)�5�      $	 0.379,0.403&�5�      5�      5�      5�      