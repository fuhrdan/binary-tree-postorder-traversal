//*****************************************************************************
//** 145. Binary Tree Postorder Traversal  leetcode                          **
//*****************************************************************************


/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     struct TreeNode *left;
 *     struct TreeNode *right;
 * };
 */
/**
 * Note: The returned array must be malloced, assume caller calls free().
 */

// Helper function to recursively perform postorder traversal
void postorderTraversalHelper(struct TreeNode* root, int* list, int* size) {
    if (root == NULL) {
        return;
    }

    // Traverse the left subtree
    postorderTraversalHelper(root->left, list, size);

    // Traverse the right subtree
    postorderTraversalHelper(root->right, list, size);

    // Add the root's value to the list
    list[(*size)++] = root->val;
}

// Function to initiate the postorder traversal
int* postorderTraversal(struct TreeNode* root, int* returnSize) {
    // Allocate memory for the result array
    int* result = (int*)malloc(100 * sizeof(int)); // Assuming max of 100 elements in the tree
    *returnSize = 0;

    // Call the helper function to fill the result array
    postorderTraversalHelper(root, result, returnSize);

    return result;
}