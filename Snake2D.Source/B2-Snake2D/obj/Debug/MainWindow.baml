   M S B A M L   `   `   `  ����E  AB2-Snake2D, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:B2_Snake2D
B2_Snake2D  5   	       B2_Snake2D.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:B2_Snake2D     5   	   -   5          � Title$  	Snake 0.5��5   	   $	��510��6   $	��777��6(    � WindowStartupLocation$ CenterScreen=�5	   	    � 
ResizeMode$ CanMinimize=�6/   ��5      
� 5   
   .��5      �  � Color$ 	#FFAEB09F��6    � Offset$ 0.568Q�6-   � 5      $ 	#FFAAA6A6��6   $ 1Q�6-   5      .��5      � $��0,0,0,-1q�6   .+�5   
   �� -   5         ��Name$ button��5      $��
Start Game��6$   $
��Left=�66   $��319,149,0,0q�6Q    J� SnapsToDevicePixels . $	��Top=�6�   $	��122��6�   $��34��6�   $��22(�6�   $
��Bold"�6�   ���	#FFE2DBDB J� IsHitTestVisible . ��6�   Z�  J� Effect 5      -  'System.Windows.Media.Effects.BlurEffect  5      	   Radius$	 0Q�6   -   5        
blurEffect��5   (   
 � Triggers
 5      :� 5       :� RoutedEvent$ 
MouseEnter��6   .[�5      �� .��5       �� .��5!      W�  W� From$ 0X�6.   	 W� To$ 4X�67    g� Duration$ 0:0:0.1D�6>    �� 
TargetName$ 
blurEffect��5"   %    �� TargetProperty$ Radius�6H   5#      5$      5%      :� 5'      $ 
MouseLeave��6   .[�5(      �� .��5)      �� .��5*      W� $ 4X�6.   $ 0X�67   $ 0:0:0.4D�6>   $ 
blurEffect��5+   !   $ Radius�6D   5,      5-      5.      50      �� 52   
   -   5        $ button_Copy��52      $��Leaderboard��6)   $
��Left=�6<   $��311,217,0,0q�6W   $	��Top=�6m   $	��139��6�   $��34��6�   $��22(�6�   $
��Bold"�6�   ���	#FFE2DBDB . ��6�   Z�  53        54      $	 0Q�6   -   5        blurEffectt��54   (   
 57      :� 58      $ 
MouseEnter��6   .[�59      �� .��5:      �� .��5;      W� $ 0X�6.   $ 4X�67   $ 0:0:0.1D�6>   $ blurEffectt��5<   %   $ Radius�6I   5=      5>      5?      :� 5A      $ 
MouseLeave��6   .[�5B      �� .��5C      �� .��5D      W� $ 4X�6.   $ 0X�67   $ 0:0:0.4D�6>   $ blurEffectt��5E   !   $ Radius�6E   5F      5G      5H      5J      �� 5N   
   -   5        $ button_Copy1��5N      $
��Exit��6*   $
��Left=�66   $��347,281,0,0q�6Q   $	��Top=�6f   $��67��6~   $��34��6�   $��22(�6�   $
��Bold"�6�   ���	#FFE2DBDB . ��6�   Z�  5O        5P      $	 0Q�6   -   5        blurEffecttt��5P   (   
 5S      :� 5T      $ 
MouseEnter��6   .[�5U      �� .��5V      �� .��5W      W� $ 0X�6.   $ 4X�67   $ 0:0:0.1D�6>   $ blurEffecttt��5X   %   $ Radius�6J   5Y      5Z      5[      :� 5]      $ 
MouseLeave��6   .[�5^      �� .��5_      �� .��5`      W� $ 4X�6.   $ 0X�67   $ 0:0:0.4D�6>   $ blurEffecttt��5a   !   $ Radius�6F   5b      5c      5d      5f      �� 5h   
   -   5         ��Name$ button_Copy2��5h      $��1.��6'   $
��Left=�64   $��202,157,0,0q�6O   $	��Top=�6d   $��67��6|   $��34��6�   $��22(�6�   $
��Bold"�6�   ���	#FFE2DBDB .  $y�Hidden=�6+  ��6�   Z� ��6�   Z� 6+  �� 5i   
   -	   5        $ button_Copy3��5i      $��2.��6'   $
��Left=�64   $��202,206,0,0q�6O   $	��Top=�6d   $��67��6|   $��34��6�   $��22(�6�   $
��Bold"�6�   ���	#FFE2DBDB .  $y�Hidden=�6+  ��6�   Z� ��6�   Z� 6+  �� 5j   
   -
   5        $ button_Copy4��5j      $��3.��6'   $
��Left=�64   $��202,255,0,0q�6O   $	��Top=�6d   $��67��6|   $��34��6�   $��22(�6�   $
��Bold"�6�   ���	#FFE2DBDB .  $y�Hidden=�6+  ��6�   Z� ��6�   Z� 6+  �� 5k   
   -   5        $ button_Copy5��5k      $��Return to menu��6*   $
��Left=�6@   $��576,403,0,0q�6[   $	��Top=�6p   $	��169��6�   $��34��6�   $��22(�6�   $
��Bold"�6�   ���	#FFE2DBDB . $y�Hidden=�6+  ��6�   Z�  5l        5m      $	 0Q�6   -   5        blurEffectttt��5m   (   
 5p      :� 5q      $ 
MouseEnter��6   .[�5r      �� .��5s      �� .��5t      W� $ 0X�6.   $ 4X�67   $ 0:0:0.1D�6>   $ blurEffectttt��5u   %   $ Radius�6K   5v      5w      5x      :� 5z      $ 
MouseLeave��6   .[�5{      �� .��5|      �� .��5}      W� $ 4X�6.   $ 0X�67   $ 0:0:0.4D�6>   $ blurEffectttt��5~   !   $ Radius�6G   5      5�      5�      5�      �� 5�   
   -   5        $ 	textBlock��5�      $
��Left=�6'   $��269,159,0,0q�6B   $
��Wrap=�6W   $��no score��6k   $	��Top=�6{   $��22(�6�   $
��Bold"�6�   ���	#FFE2DBDB$y�Hidden=�6�   �� 5�   
   -   5        $ textBlock_Copy��5�      $
��Left=�6,   $��269,208,0,0q�6G   $
��Wrap=�6\   $��no score��6p   $	��Top=�6�   $��22(�6�   $
��Bold"�6�   ���	#FFE2DBDB$y�Hidden=�6�   �� 5�   
   -   5        $ textBlock_Copy1��5�      $
��Left=�6-   $��269,257,0,0q�6H   $
��Wrap=�6]   $��no score��6q   $	��Top=�6�   $��22(�6�   $
��Bold"�6�   ���	#FFE2DBDB$y�Hidden=�6�    � 5�   
   -   5          �Name$
 Main��5�        � NavigationUIVisibility$ Hidden=�6   $��0,0,0,1                q�6>   �� 5�   
   -   5        $ button_Copy6��5�      $��Return to menu��6*   $
��Left=�6@   $��576,437,0,0q�6[   $	��Top=�6p   $	��169��6�   $��34��6�   $��22(�6�   $
��Bold"�6�   ���	#FFE2DBDB . $y�Hidden=�6%  ��6�   Z�  5�        5�      $	 0Q�6   -   5        blurEffecttttt��5�   (   
 5�      :� 5�      $ 
MouseEnter��6   .[�5�      �� .��5�      �� .��5�      W� $ 0X�6.   $ 4X�67   $ 0:0:0.1D�6>   $ blurEffecttttt��5�   %   $ Radius�6L   5�      5�      5�      :� 5�      $ 
MouseLeave��6   .[�5�      �� .��5�      �� .��5�      W� $ 4X�6.   $ 0X�67   $ 0:0:0.4D�6>   $ blurEffecttttt��5�   !   $ Radius�6H   5�      5�      5�      5�      �� 5�   
   -   5        $ button_Copy7��5�      $��PLAY!��6*   $
��Left=�67   $��347,255,0,0q�6R   $	��Top=�6g   $��67��6   $��34��6�   $��22(�6�   $
��Bold"�6�   ���	#FFE2DBDB . $y�Hidden=�6  ��6�   Z�  5�        5�      $	 0Q�6   -   5        blurEffectttttT��5�   (   
 5�      :� 5�      $ 
MouseEnter��6   .[�5�      �� .��5�      �� .��5�      W� $ 0X�6.   $ 4X�67   $ 0:0:0.1D�6>   $ blurEffectttttT��5�   %   $ Radius�6M   5�      5�      5�      :� 5�      $ 
MouseLeave��6   .[�5�      �� .��5�      �� .��5�      W� $ 4X�6.   $ 0X�67   $ 0:0:0.4D�6>   $ blurEffectttttT��5�   !   $ Radius�6I   5�      5�      5�      5�      �� 5�   
   -   5         ��Name$ textBox��5�      $
��Left=�6#   $��29��6>   $��294,221,0,0q�6J    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��165��6�    �� 
CaretBrush �	#FFE2DBDB���	#FFE2DBDB �� SelectionBrush �	#FFDED0D0���	#FFE2DBDB$��18(�6  $y�Hidden=�6  ��6�   Z� 6  �� 5�   
   -   5        $ button_Copy8��5�      $��	Nickname:��6*   $
��Left=�6;   $��319,188,0,0q�6V   $	��Top=�6k   $	��117��6�   $��30��6�   $��22(�6�   $
��Bold"�6�   ���	#FFE2DBDB .  $y�Hidden=�6  ��6�   Z�  5�        5�      $	 0Q�6   -   5        blurEffectttttT1��5�   (   5�      5�      5�      