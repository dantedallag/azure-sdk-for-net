// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.OracleDatabase.Samples
{
    public partial class Sample_DbSystemShapeResource
    {
        // Get a DbSystemShape by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetADbSystemShapeByName()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/preview/2023-09-01-preview/examples/dbSystemShapes_get.json
            // this example is just showing the usage of "DbSystemShapes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DbSystemShapeResource created on azure
            // for more information of creating DbSystemShapeResource, please refer to the document of DbSystemShapeResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            AzureLocation location = new AzureLocation("eastus");
            string dbsystemshapename = "EXADATA.X9M";
            ResourceIdentifier dbSystemShapeResourceId = DbSystemShapeResource.CreateResourceIdentifier(subscriptionId, location, dbsystemshapename);
            DbSystemShapeResource dbSystemShape = client.GetDbSystemShapeResource(dbSystemShapeResourceId);

            // invoke the operation
            DbSystemShapeResource result = await dbSystemShape.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DbSystemShapeData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
