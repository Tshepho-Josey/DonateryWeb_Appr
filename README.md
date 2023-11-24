# DonateryWeb_Appr
Tshepho Josey Appr Part2 Repository
Change Log: Original Page Modifications

1.	Existing Styles Preservation:
Ensured preservation of the original styles specified in the <style> tag at the beginning of the page.

2.	Added Title:
Included a new title, "Edit Disaster Allocation Information," to clearly indicate the purpose of the page.

3.	Loop Through Model for Display:
Utilized a foreach loop to iterate through each item in the Model and display allocation information in a table format.

4.	Added Form Container Styling (Optional):
Introduced optional styling for a form container (div.form-container) to organize and present the editing form in a clean layout.

5.	Form Elements for Editing:
Added form elements within the loop, including text inputs and hidden fields, to allow users to edit allocation information.

6.	Hidden Input for AllocationId:
Included a hidden input field (<input type="hidden" name="AllocationId" value="@item.AllocationId" />) to store the AllocationId for each form, ensuring the correct item is updated upon submission.

7.	Submit Form to Edit Action:
Set the form to submit to the Edit action in the corresponding controller using asp-action="Edit".


8.	Back to Home Link:
Included a link (<a asp-action="Index">Back to Home</a>) to navigate back to the home page.

9.	Existing Styling and Structure:
Maintained the overall styling and structure from the original page for consistency.

10.	User Guidance:
Provided comments for better understanding of code sections.
