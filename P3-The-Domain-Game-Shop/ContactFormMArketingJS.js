

// Code to run in the column OnChange event 
this.CountryOnChange = function (executionContext) {
    var formContext = executionContext.getFormContext();

    //Automatically set "wakanda" to start with upper case
    var contactCountry = formContext.getAttribute("address1_country").getValue();
    if(contactCountry.search("wakanda") != -1)
    {
        formContext.getAttribute("address1_country").setValue("Wakanda");
    }
}