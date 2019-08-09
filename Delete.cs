        public async Task {repo_name}_Delete_ReturnTrue()
        {
            var result = await repository.Delete(new Guid(/* Guid here */));
            var objAfterDelete = await repository.Get(new Guid(/* Guid same above */));
            if (objAfterDelete == null) Assert.IsTrue(result);
            else Assert.AreEqual(objAfterDelete.Disabled, true);
        }