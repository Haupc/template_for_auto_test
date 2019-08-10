        [TestMethod]
        public async Task {repo_name}_Skip2AndTake10_DESC_ReturnValid()
        {
            {repo_name}Filter filter = new {repo_name}Filter()
            {
                OrderBy = {repo_name}Order.{field_name},
                OrderType = OrderType.DESC,
                Selects = {repo_name}Select.{field_name},
                Skip = 2,
                Take = 10,
            };

            var result = await repository.List(filter);
            var list{field_name}s = string.Join(",", result.Select(r => r.{field_name}));
            var expected = await this.DbContext.{repo_name}.OrderByDescending(b => b.{field_name}).Select(b => b.{field_name}).Skip(2).Take(10).ToListAsync();
            Assert.AreEqual(list{field_name}s, string.Join(",", expected));
        }
