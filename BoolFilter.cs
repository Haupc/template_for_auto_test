        //False
        [TestMethod]
        public async Task {repo_name}_BoolFilter_ReturnValid()
        {
            {repo_name}Filter filter = new {repo_name}Filter
            {
                {field_name} = false
            };

            var result = await repository.Count(filter);
            var expected = await DbContext.{repo_name}.Where(b => !b.{field_name}).Select(b => b.Id).CountAsync();
            Assert.AreEqual(expected, result);
        }