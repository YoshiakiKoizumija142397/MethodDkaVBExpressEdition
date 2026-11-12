Option Explicit

Dim n As Integer
Dim sp As Double
Dim sq As Double
Dim sw As Double
Dim se As Double
Dim m As Integer
Dim i As Integer
Dim j As Integer
Dim k As Integer
Dim sb As Double
Dim sc As Double
Dim s1 As Double
Dim s2 As Double
Dim s3 As Double
Dim s4 As Double
Dim s5 As Double
Dim st As Double
Dim sa(1000) As Double
Dim sr(1000) As Double
Dim si(1000) As Double

Rem 高次代数方程式
Rem DKA法の修正版

Private Sub Command3_Click()
    n = Val(Text1.Text)
    Label1.Caption = n
End Sub

Private Sub Form_Load()
    Me.ScaleMode = 1
    Me.ScaleHeight = 11340
    Me.ScaleWidth = 10206
End Sub

Private Sub Label4_Click()
    Dim i As Integer
    i = 0
    Do Until i > n
        Label4.Caption = CStr(n - i) & " 次の係数は？"
        sa(i) = Val(InputBox(CStr(n - i)))
        If sa(0) = 0 Then
            MsgBox "最高次数の係数が 0 (ゼロ) の場合は最高次数を下げてください！！"
            GoTo lbl5
        End If
        Label3.Caption = sa(i)
        i = i + 1
    Loop
lbl5:
    Rem "最高次を下げる"
End Sub

Private Sub Command1_Click()
    Dim sx(1000) As Double
    Dim sy(1000) As Double
    se = 0.00000000000001
    m = 100
    sp = 3.14159265358979
    sw = 0

    For i = 1 To n
        sa(i) = sa(i) / sa(0)
    Next i

    For i = 2 To n
        sq = n * (Abs(sa(i))) ^ (1 / i)
        If sw < sq Then sw = sq
    Next i

    sb = 2 * sp / n
    sc = sp / (2 * n)

    For j = 1 To n
        st = sb * (j - 1) + sc
        sr(j) = sw * Cos(st)
        si(j) = sw * Sin(st)
    Next j

    For k = 1 To m
        For i = 1 To n
            s1 = 1
            s2 = 0
            s3 = 1
            s4 = 0
            sb = sr(i)
            sc = si(i)

            For j = 1 To n
                s5 = s1 * sb - s2 * sc
                s2 = s1 * sc + s2 * sb
                s1 = s5 + sa(j)
                If j = i Then GoTo lbl1
                s5 = s3 * (sb - sr(j)) - s4 * (sc - si(j))
                s4 = s3 * (sc - si(j)) + s4 * (sb - sr(j))
                s3 = s5
lbl1:
            Next j

            sw = s3 * s3 + s4 * s4
            sx(i) = (s1 * s3 + s2 * s4) / sw
            sy(i) = (s2 * s3 - s1 * s4) / sw

            sr(i) = sr(i) - sx(i)
            si(i) = si(i) - sy(i)
        Next i

        For i = 1 To n
            If Abs(sx(i)) > se Then GoTo lbl2
            If Abs(sy(i)) > se Then GoTo lbl2
        Next i
        GoTo lbl3

lbl2:
    Next k

    Label5.Caption = "収束しませんでした！"
    GoTo lbl4

lbl3:
    Label5.Caption = "収束しました！"

lbl4:
    Rem "計算終了"
End Sub

Private Sub Command2_Click()
    End
End Sub

Private Sub Command5_Click()
    Dim i As Integer
    i = 1
    Do Until i > n
        MsgBox i & " 番目の解"
        MsgBox "実数部: " & sr(i)
        MsgBox "虚数部: " & si(i)
        i = i + 1
    Loop
End Sub
