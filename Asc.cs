        [TestMethod]
        public async Task {repo_name}Repository_List_ReturnTrue_OrderASC()
        {
            {repo_name}Filter filter = new {repo_name}Filter
            {
                {field_name} = new StringFilter { StartsWith = /** pattern here */ },
                OrderBy = {repo_name}Order.{field_name},
                OrderType = OrderType.DESC,
                Skip = 1,
                Take = 2
            };
            var result = await {repo_name}Repository.List(filter);
            int i = 1;
            for (int index = 0; index < result.Count; index++)
            {
                Assert.AreEqual(/** string patern */ + i.ToString(), result[index]);
                i++;
            }
        }