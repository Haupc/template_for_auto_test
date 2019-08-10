        [TestMethod]
        public async Task {repo_name}_Skip0AndTake10_ASC_ReturnValid()
        {
            {repo_name}Filter filter = new {repo_name}Filter()
            {
                OrderBy = {repo_name}Order.{field_name},
                Selects = {repo_name}Select.{field_name},
                Skip = 0,
                Take = 10,
            };

            var result = await repository.List(filter);
            var list{field_name} = string.Join(",", result.Select(r => r.{field_name}));
            var expected = await this.DbContext.{repo_name}.OrderBy(b => b.{field_name}).Select(b => b.{field_name}).Skip(0).Take(10).ToListAsync();
            Assert.AreEqual(list{field_name}, string.Join(",", expected));
        }