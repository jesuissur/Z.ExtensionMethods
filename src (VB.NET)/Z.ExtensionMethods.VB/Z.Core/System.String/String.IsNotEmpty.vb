
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Public Module Extensions_506

	''' <summary>
	'''     A string extension method that queries if a not is empty.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>true if a not is empty, false if not.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsNotEmpty(this As String) As Boolean
		Return this <> ""
	End Function
End Module


