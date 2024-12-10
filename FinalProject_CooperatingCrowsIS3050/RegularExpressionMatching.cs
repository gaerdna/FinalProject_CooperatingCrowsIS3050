/*
 # Name: Madison Geier
# email: geierml@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 12/10/24
# Course: IS 3050
# Semester/Year: Fall 2024
# Brief Description: This project ... Creating a webpage with buttons to problems
# Citations: Gemini
# Anything else that's relevant: n/a
*/
<%@ Page Language = "C#" AutoEventWireup="true" CodeBehind="RegularExpressionMatching.aspx.cs" Inherits="FinalProject_CooperatingCrowsIS3050.RegularExpressionMatching" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
    public static bool IsMatch(string s, string p)
{
    int m = s.Length;
    int n = p.Length;

    // Create a 2D boolean array for dynamic programming
    bool[,] dp = new bool[m + 1, n + 1];

    // Base case: empty string matches empty pattern
    dp[0, 0] = true;

    for (int i = 1; i <= m; i++)
    {
        for (int j = 1; j <= n; j++)
        {
            if (p[j - 1] == s[i - 1] || p[j - 1] == '.')
            {
                dp[i, j] = dp[i - 1, j - 1];
            }
            else if (p[j - 1] == '*')
            {
                // Match zero characters
                dp[i, j] = dp[i, j - 2];

                if (p[j - 2] == s[i - 1] || p[j - 2] == '.')
                {
                    // Match zero or more characters
                    dp[i, j] = dp[i, j] | dp[i - 1, j];
                }
            }
        }
    }

    return dp[m, n];
}
        </div>
    </form>
</body>
</html>
