   M S B A M L   `   `   `  ����B  >WpfApp4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WpfApp4.ViewModelWpfApp4.ViewModel  5      !clr-namespace:WpfApp4WpfApp4  5   	       WpfApp4.PrismMaker   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5	viewModelclr-namespace:WpfApp4.ViewModel     5      'localclr-namespace:WpfApp4     5   	   R NOxyPlot.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=75e952ba404cdbb0 oxyhttp://oxyplot.org/wpf  5
        � Title$  
PrismMaker��5   	   $	��700��6   $	��444��6)    � WindowStyle$
 None=�5       � 
ResizeMode$ NoResize=�5       � DataContext 5      +  %WpfApp4.ViewModel.PrismMakerViewModel  5       � 	Resources 5      +   %WpfApp4.BooleanToStringValueConverter !  BooleanToStringValueConverter(   "WpfApp4.TranslatToVisibleConverter  TranslatToVisibleConverter&    WpfApp4.RotateToVisibleConverter  RotateToVisibleConverter%   WpfApp4.ScaleToVisibleConverter  ScaleToVisibleConverter��%t   &	        &	      &	 &     &	 9       5      6(     5      6%     5      6#     5      6"   5      .��5      �� .+�5      �� -   5         �� Orientation$ 
Horizontal=�5      
����  �$��50��6_   $��0,0,0,10q�6k   .+�5      �� 
�������$��24(�6"   $��	5,5,165,5q�60   Prism Maker6P   �� 5      -   5        $��	90,5,0,00q�5      $��40��6   $0��*pack://application:,,,/Resources/close.png��6E   5       �� 5"      $ 
Horizontal=�6   .+�5#      �� $ Vertical=�6   $��5,5,5,10q�6'   .+�5$      �� $ Vertical=�6   $��0,0,0,0q�6(   $
�� 420��69   
�������.+�5%      �� $ 
Horizontal=�6   .+�5&      �� $
��Bold"�6   $��5q�6$   List of old polygon's points:6N   �� 5'      $
��Bold"�6   $��55,5,5,5q�6$   List of new polygon's points:6U   5(      �� 5)      $ 
Horizontal=�6   .+�5*      &   System.Windows.Controls.DataGrid  $	��200��6   $	��150��6   {�. $��5,0,15,0q�6�      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ 90 6�   ��6*   �� *
PointsList+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�     5+      	   
IsReadOnly	 . $	��200��6#   $	��150��6/   {�. $��5,0,0,0q�6�   $ 90 6�   ��6<   �� *EditedPointsList+$ TwoWay=�$ PropertyChanged=�6�   5-      	� 5/      -   5        $��RadioButton1��5/      
 	� 	GroupName$
 Group1��50      $��	Translate��51       d� 	IsChecked 52      ��  �� Path$ 	Property1� �� 	Converter# [   �� ConverterParameter$ 	Translate��	� 53      -   5        $��RadioButton2��53      $
 Group1��54      $��Rotate��55       56      �� $ 	Property1�# [  $ Rotate��	� 57      -   5        $��RadioButton3��57      $
 Group1��58      $��Scale��59       5:      �� $ 	Property1�# [  $ Scale���� 5<      $ 
Horizontal=�6   y�6+   �� *	Property1+# [ .+�5>      �� $��5q�6   
Translate:6)   �� 5?      $��5q�6   x:6!   �� 5@      -   5         ��Name$ TranslateTxtBoxX��5@      $��50��6*   $��20��65   ��6A   �� *
TranslateX+$ TwoWay=�$ PropertyChanged=��� 5A      $��5q�6   y:6!   �� 5B      -   5        $ TranslateTxtBoxY��5B      $��50��6*   $��20��65   ��6B   �� *
TranslateY+$ TwoWay=�$ PropertyChanged=�5C      �� 5D      $ 
Horizontal=�6   y�6+   �� *	Property1+# [ .+�5E      �� $��5q�6   	Rotate:6&   �� 5F      $��5q�6   angle:6%   �� 5G      -   5        $ RotateTxtBox��5G      $��50��6&   $��20��61   ��6=   �� *RotateAngle+$ TwoWay=�$ PropertyChanged=��� 5H      $��5q�6   Base point:6*   �� 5I      $��5q�6   x:6"   �� 5J      $��50��6   $��20��6   ��6'   �� *RotateBasePointX+$ TwoWay=�$ PropertyChanged=��� 5K      $��5q�6   y:6"   �� 5L      $��50��6   $��20��6   ��6(   �� *RotateBasePointY+$ TwoWay=�$ PropertyChanged=�5N      �� 5O      $ 
Horizontal=�6   y�6+   �� *	Property1+# [ .+�5P      �� $��5q�6   Scale:6%   �� 5Q      $��5q�6   k:6!   �� 5R      -	   5        $ ScaleTxtBox��5R      $��50��6%   $��20��60   ��6<   �� *Scale+$ TwoWay=�$ PropertyChanged=��� 5S      $��5q�6   Base point:6*   �� 5T      $��5q�6   x:6"   �� 5U      $��50��6   $��20��6   ��6'   �� *ScaleBasePointX+$ TwoWay=�$ PropertyChanged=��� 5V      $��5q�6   y:6"   �� 5W      $��50��6   $��20��6   ��6(   �� *ScaleBasePointY+$ TwoWay=�$ PropertyChanged=�5Z      �� 5[      -
   5        $��
cmdCommand��5[   k   $	��400��6   $��30��6   $��5q�6&   
���   �
�������$��	Calculate��6W   ��6}   �� $ ClickCommand�  OxyPlot.Wpf.Plot  5]      $	��250��6   $	��250��6      Series 5^      	  OxyPlot.Wpf.LineSeries	  5_   	   ��6   �� *PointsList2+$ TwoWay=�$ PropertyChanged=�	  5`   	   ��6   �� *EditedPointsList2+$ TwoWay=�$ PropertyChanged=�5b      �� 5c      $ 
Horizontal=�6   .+�5d      �� $ Vertical=�6   $��	20,0,80,0q�6*   .+�5e   	   �� Base polygon:6"   �� 5f   
   $ 
Horizontal=�6   .+�5g   
   �� $��75��6   
Circuit:6)   �� 5h   
   -   5        $ CirciuitListTxtBox��5h   $    �� 
IsReadOnly . $��75��6Y   ��6@   �� *	Circuit+6Y   5i   
   �� 5j   	   $ 
Horizontal=�6   .+�5k   
   �� $��75��6   Area:6&   �� 5l   
   -   5        $ AreaListTxtBox��5l   $    . $��75��6R   ��6<   �� *Area+6R   5m   
   5n   	   �� 5p      $ Vertical=�6   .+�5q   	   �� Edited polygon:6$   �� 5r   	   $ 
Horizontal=�6   .+�5s   
   �� $��75��6   
Circuit:6)   �� 5t   
   -   5        $ CirciuitEditedListTxtBox��5t   $    . $��75��6`   ��6F   �� *
Circuit2+6`   5u   
   �� 5v   	   $ 
Horizontal=�6   .+�5w   
   �� $��75��6   Area:6&   �� 5x   
   -   5        $ AreaEditedListTxtBox��5x   $    . $��75��6Y   ��6B   �� *Area2+6Y   5y   
   5z   	   5{      5|      5}      5      �� 5�      
�����w�$��50��6+   $��0,0,0,10q�67   .+�5�      �� 
�������$��24(�6"   $��5q�60   Jakub Szymczak 2171396R   5�      5�      5�      