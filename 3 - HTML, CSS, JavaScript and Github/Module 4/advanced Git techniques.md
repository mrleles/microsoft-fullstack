# Step 1: Create and Manage Branches
cd <your-repository>
git checkout -b feature-new-feature
# Make changes to a file
git add .
git commit -m "Add new feature"

# Step 2: Merge Branches and Resolve Conflicts
git checkout main
# Edit a file
git add .
git commit -m "Edit file in main branch"
git checkout feature-new-feature
# Make changes to the file
git add .
git commit -m "Edit file in feature branch"
git checkout main
git merge feature-new-feature
# Resolve conflicts in your editor
git add .
git commit -m "Resolve merge conflict"

# Step 3: Use Tags to Mark important Commits
git tag -a v1.0 -m "Initial release"
git push origin v1.0

# Step 4: Stash Changes Temporarily
# make changes but do not commit
git stash
git checkout main
git stash list
git stash apply

# Step 5: Perform interactive Rebase
git rebase -i HEAD~4
# Resolve conflicts if needed
git add .
git rebase --continue
git push --force