        [TestMethod]
        public async Task {repo_name}_BulkMerge()
        {
            List<{repo_name}> newObject = new List<{repo_name}>();

            for(int i = 0; i < 2; i++)
            {
                newObject.Add (new {repo_name}
                {
                    {field_name_i} = /** init data here */, /** 2 id must be diff */
                });
            }

            var result = await repository.BulkInsert(newObject);

            var expectedDAO1 = await DbContext.{repo_name}
                .Where(s => s.Id.Equals(CreateGuid("NewGuid0")))
                .AsNoTracking()
                .FirstOrDefaultAsync();
            var expectedDAO2 = await DbContext.{repo_name}
                .Where(s => s.Id.Equals(CreateGuid("NewGuid1")))
                .AsNoTracking()
                .FirstOrDefaultAsync();

            Assert.AreEqual(expectedDAO1.{field_name_i}, newObject[0].{field_name_i});

            Assert.AreEqual(expectedDAO2.{field_name_i}, newObject[1].{field_name_i});

            Assert.IsTrue(result);
        }
        