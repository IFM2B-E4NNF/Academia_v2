<%@ Page Title="" Language="C#" MasterPageFile="~/RegSite.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Academia_IFM02B2_Project_Website.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="min-h-screen flex items-center justify-center bg-gray-50 py-12 px-4 sm:px-6 lg:px-8">
        <div class="max-w-md w-full space-y-8">
            <div>
                <img class="mx-auto h-12 w-auto" src="assets/img/Logo.png" alt="Workflow">
                <h2 class="mt-6 text-center text-3xl font-extrabold text-gray-900">Sign in to your account
                </h2>
                <p class="mt-2 text-center text-sm text-gray-600">
                    Or
             
                    <a href="Register.aspx" class="font-medium text-blue-600 hover:text-blue-400">Register an account now
                    </a>
                </p>
            </div>
            
                <input type="hidden" name="remember" value="true">
                <div class="rounded-md shadow-sm -space-y-px">
                    <div>
                        <label for="email-address" class="sr-only">Email address</label>
                        <input id="email" name="email" runat="server" type="email" autocomplete="email" required class="appearance-none rounded-none relative block w-full px-3 py-2 border border-gray-300 placeholder-gray-500 text-gray-900 rounded-t-md focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 focus:z-10 sm:text-sm" placeholder="Email address">
                    </div>
                    <div>
                        <label for="password" class="sr-only">Password</label>
                        <input id="password" runat="server" name="password" type="password" autocomplete="current-password" required class="appearance-none rounded-none relative block w-full px-3 py-2 border border-gray-300 placeholder-gray-500 text-gray-900 rounded-b-md focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 focus:z-10 sm:text-sm" placeholder="Password">
                    </div>
                </div>

                <div class="flex items-center justify-between">
                    <div class="flex items-center">
                        <%--<input id="remember-me" name="remember-me" type="checkbox" class="h-4 w-4 text-indigo-600 focus:ring-indigo-500 border-gray-300 rounded">--%>
                        <label for="remember-me" id="results" runat="server" class="ml-2 block text-sm text-gray-900">
                           
               
                        </label>
                    </div>

                    <div class="text-sm">
                        <a href="#" class="font-medium text-blue-600 hover:text-blue-400">Forgot your password?
                        </a>
                    </div>
                </div>

                <div>


                        <asp:Button type="submit" class=" btn group relative w-full flex justify-center py-2 px-4 border border-transparent text-sm font-medium rounded-md text-white focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"
                            ID="Button1" runat="server" Text=" Sign in" OnClick="Btn_Login" />
                 


                </div>
           
        </div>
    </div>


</asp:Content>
