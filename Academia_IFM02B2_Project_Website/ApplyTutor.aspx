<%@ Page Title="" Language="C#" MasterPageFile="~/RegSite.Master" AutoEventWireup="true" CodeBehind="ApplyTutor.aspx.cs" Inherits="Academia_IFM02B2_Project_Website.ApplyTutor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="mt-10 sm:mt-0 min-h-screen flex items-center justify-center bg-gray-50 py-12 px-4 sm:px-6 lg:px-8">
        <div class="max-w-lg w-full space-y-8">

            <div class="mt-5 md:mt-0 md:col-span-2">
                <div class="shadow overflow-hidden sm:rounded-md">
                    <div>
                        <img class="mx-auto h-12 w-auto" src="assets/img/Logo.png" alt="Workflow">
                        <h2 class="mt-6 text-center text-3xl font-bold text-gray-900">Subject Details
                        </h2>

                    </div>
                    <div class="px-4 py-5 bg-white sm:p-6">
                        <div class="grid grid-cols-6 gap-6">

                            <div class="col-span-6 sm:col-span-3">
                                <label class="block text-sm font-medium text-gray-700">Subject name<a style="color: dimgray;">*</a></label>
                                <input id="name" runat="server" name="name" type="text" class="appearance-none rounded-none relative block w-full px-3 py-2 border border-gray-300 placeholder-gray-500 text-gray-900 rounded-b-md focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 focus:z-10 sm:text-sm" placeholder="Subject">
                            </div>



                            <div class="col-span-6 sm:col-span-3">
                                <label class="block text-sm font-medium text-gray-700">Subject Category<a style="color: dimgray;">*</a></label>


                                <select id="category" runat="server" name="subjects" autocomplete="subject" required="required" class="mt-1 block w-full py-2 px-3 border border-gray-300 bg-white rounded-md shadow-sm focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm">
                                    <option>Business</option>
                                    <option>Humanities</option>
                                    <option>Mathematics</option>
                                    <option>Programming</option>
                                    <option>Science</option>
                                    <option>Engineering</option>
                                    <option>Computer Science</option>
                                    <option>Law</option>
                                    <option>Foreign Languages</option>

                                </select>

                            </div>




                            <div class="col-span-6">
                                <label class="block text-sm font-medium text-gray-700">Subject Description <a style="color: dimgray;">*</a></label>

                                <textarea id="description" runat="server" cols="20" rows="4" required="required" class="border border-gray mt-1 focus:ring-indigo-500 focus:border-indigo-500 block w-full shadow-sm sm:text-sm border-gray-300 rounded-md"></textarea>

                            </div>


                            <div class="col-span-6 sm:col-span-4">
                                <label class="block text-sm font-medium text-gray-700">Subject price<a style="color: dimgray;">*</a></label>
                                <input id="price" runat="server" name="money" type="number" data-type="money" required="required" class="appearance-none rounded-none relative block w-full px-3 py-2 border border-gray-300 placeholder-gray-500 text-gray-900 rounded-b-md focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 focus:z-10 sm:text-sm" placeholder="Subject price">
                            </div>



                        </div>
                        <p id="message" runat="server"></p>
                    </div>
                    <div class="flex items-center justify-between">
                        <div class="flex items-center">
                            <label for="have-account" id="results" runat="server" class="ml-2 block text-sm text-gray-900">
                            </label>
                        </div>
                    </div>


                    <div class="px-4 py-3 bg-gray-50 text-center sm:px-6">
                        <div class="col-span-4 sm:col-span-3">
                            <label for="price" class="block text-sm font-medium text-gray-700">Subject Simple Picture<a style="color: dimgray;">*</a></label>


                            <asp:FileUpload ID="FileUpload1" runat="server" />
                            <asp:Button ID="btnUpload" runat="server" Text="Apply" class="inline-flex justify-center py-2 px-4 border border-transparent shadow-sm text-sm font-medium rounded-md text-white bg-yellow-600 hover:bg-yellow-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"
                                OnClick="Btn_ApplyTutor" />


                        </div>
                    </div>



                </div>


            </div>

        </div>
    </div>
</asp:Content>
