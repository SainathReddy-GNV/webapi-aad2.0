# Calling Microsoft Identity Platform protected Web APIs from Angular 7 App([@azure/msal]([https://www.npmjs.com/package/@azure/msal](https://www.npmjs.com/package/@azure/msal)))

## How to run this sample

To run this sample, you'll need:
- [Visual Studio 2019](https://visualstudio.microsoft.com/downloads/)
- An Azure Active Directory (Azure AD) tenant. For more information on how to get an Azure   AD tenant, refer [Azure Docs](https://docs.microsoft.com/en-gb/azure/active-directory/)

### Step 1: Clone or download this repository
From your shell or command line:
```
git clone https://github.com/SainathReddy-GNV/webapi-aad2.0.git
```
or download and extract the repository .zip file.

### Step 2: Register the Web API with your Azure Active Directory tenant
1.  Sign in to the  [Azure portal](https://portal.azure.com/)  using either a work or school account or a personal Microsoft account.
2.  If your account is present in more than one Azure AD tenant, select  `Directory + Subscription`  at the top right corner in the menu on top of the page, and switch your portal session to the desired Azure AD tenant.
3.  In the left-hand navigation pane, select the  **Azure Active Directory**  service, and then select  **App registrations**.

**Register the Web API(webapi-oauth2)**
1. In **App registrations** page, select New registration
2.  When the  **Register an application page**  appears, enter your application's registration information:
    
    -   In the  **Name**  section, enter a meaningful application name that will be displayed to users of the app, for example  `WebAPI-OAuth2`.
    -   In the  **Supported account types**  section, select  **Accounts in this organizational directory only (Default Directory)**.
    -   In the Redirect URI (optional) section, select  **Web**  in the combo-box and enter the following redirect URIs.
        -   `https://localhost:44396/`
    
    > Note that if there are more than one redirect URIs, you'd need to add them from the  **Authentication**  tab later after the app has been created succesfully.
    
3.  Select  **Register**  to create the application.
    
4.  On the app  select  **Expose an API**  page, find the  **Application  ID URI**  value and record it for later. You'll need it to configure the Visual Studio configuration file for this project.


### Step 3: Configure the Web API to use your Azure AD tenant

Open the solution in Visual Studio to configure the projects

#### Configure the service project

1.  Open the  `webapi-oauth2.0\Web.Config`  file
2.  Find the app key  `ida:Audience`  and replace the existing value with the Application ID URI of the  `WebAPI-OAuth2`  application copied from the Azure portal.
3.  Find the app key  `ida:Tenant`  and replace the existing value with your Azure AD tenant name.

### Step 4: Run the sample

Clean the solution, rebuild the solution, and run it.

## To call the Web API from Angular Application 

check  [**msal-angular7** ]([https://github.com/SainathReddy-GNV/msal-angular7](https://github.com/SainathReddy-GNV/msal-angular7)) repository 







