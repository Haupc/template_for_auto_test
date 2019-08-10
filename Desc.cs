        [TestMethod]
        public async Task {repo_name}Repository_List_ReturnTrue_OrderStringDESC()
        {
            {repo_name}Filter filter = new {repo_name}Filter
            {
                {field_name} = new StringFilter { StartsWith = /** string patern */ },
                OrderBy = {repo_name}Order.{field_name},
                OrderType = OrderType.DESC,
            };
            var result = await {repo_name}Repository.List(filter);
            int i = 2;
            for (int index = 0; index < result.Count; index++)
            {
                Assert.AreEqual(/** string pattern */ + i.ToString(), result[index]);
                i--;
            }
        }