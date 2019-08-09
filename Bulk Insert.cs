        //Bulk Insert 
        [TestMethod]
        public async Task {repo_name}_BulkInsert_ReturnTrue()
        {
            var list = new List<{repo_name}>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(new {repo_name}
                {
                    {field_name_i} = /** init data here */ , /** Id must different between recodes  */
                });
            }
            var result = await repository.BulkInsert(list);
            var record1 = await repository.Get(CreateGuid("NewGuid0"));
            Assert.IsTrue(result);
            Assert.AreEqual(10, list.Count);
            Assert.AreEqual(record1.{field_name_i}, list[0].{field_name_i);
        }