   M S B A M L   `   `   `  ����F  BExamManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ExamManager.UScontrolExamManager.UScontrol  5   	   &     ExamManager.UScontrol.AddingExam   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:ExamManager.UScontrol     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   SmaterialDesign19http://schemas.microsoft.com/netfx/2009/xaml/presentation    5   	   -   5          �Name$  addingwindow��5   	      MaterialDesignBody#���   5   	   $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � WindowStyle$
 None=�5   	    � Title$ 
AddingExam��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	   $	��700��5   	   $
��1100��6   .��5      �  � RowDefinitions 5   
   �� 5      $	��150 �6   6+   �� 5      $
��auto �6   6,   .+�5   
   � $��0��6   .+�5       �� $	��Top=�5!      $��50,30,596,0q�6)    �� 
IsReadOnly . 	 �� TextWrapping$
	 Wrap=�5#      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Bài thi��5$       % !MaterialDesignFloatingHintTextBox#��[ 5%      �� 5&       � ToolTip$ Phút��5'      $	��Top=�5(      $��314,90,597,0q�6)    . $
	 Wrap=�5*      $
 Thời lượng��5+      #��[ 5,      (  "System.Windows.Controls.DatePicker  5-      $	��100��6   $
 	Mở từ��6%    ( $MaterialDesignFloatingHintDatePicker#��[ 5.      $��50,90,949,25q�6W     5/      $	��100��6   $
 Đến ngày��6%   #��[ 50      $��180,90,820,25q�6W   51      � 52   
   $��1��6    � ColumnDefinitions 53      �� 54      $	��350 �6#   61   �� 55      $
��auto �6#   62   .+�57      � $��0��6   .+�58      �� $	��Top=�59      $��
20,30,20,0q�6-   $
	 Wrap=�5:      $
 
Câu hỏi��5;       �� MaxLines$ 4��5<      #��[ 5=      �� 5>      $ 2��5?      $	��Top=�5@      $��75,130,15,0q�6-   $
	 Wrap=�5A      $
 1.��5B      #��[ 5C      �� 5D      $ 2��5E      $	��Top=�5F      $��75,190,15,0q�6-   $
	 Wrap=�5G      $
 2.��5H      #��[ 5I      �� 5J      $ 2��5K      $	��Top=�5L      $��75,250,15,0q�6-   $
	 Wrap=�5M      $
 3.��5N      #��[ 5O      �� 5P      $ 2��5Q      $	��Top=�5R      $��75,310,15,0q�6-   $
	 Wrap=�5S      $
 4.��5T      #��[ 5U      �� 5V      $
��auto��6+   $
��auto��68   $��25,145,305,390q�5W   +   6E   �� 5X      $
��auto��6+   $
��auto��68   $��25,205,305,330q�5Y   +   6E   �� 5Z      $
��auto��6+   $
��auto��68   $��25,265,305,270q�5[   +   6E   �� 5\      $
��auto��6+   $
��auto��68   $��25,325,305,210q�5]   +   6E   � 5^      $��80��6   $	��260��6#   $��69,380,22,93q�6/   .+�5_      �� $	��100��6   $��
0,0,160,48q�6)   .��6>   Thêm6D   �� 5`      $	��100��6   $��118,0,42,48q�6)   .��6>   Sửa6C   �� 5a      $	��100��6   $��
0,48,160,0q�6)   .��6=   Xóa6B   �� 5b      $	��100��6   $��118,48,42,0q�6)   .��6>   Tìm kiếm6H   5d      �� 5e      $	��150��6   $��20,485,180,30q�6%   .��6<   Hoàn tất6G   �� 5f      -   5        $	��150��5f      $��187,488,14,33q�6%   .��6Q   Hủy6V   5h      � 5i      $��1��6   .+�5j      &   System.Windows.Controls.DataGrid  $	��650��6   $	��500��6'   $��15q�64   6B   5k      5l      5m      5n      