import os
import re

README_PATH = 'README.md'
LEETCODE_URL = 'https://leetcode.com/problems/'

IGNORE_DIRS = {'.git', '.github', '.vs', 'ReadmeGenerator'}

def get_leetcode_number_and_title(folder_name):
    match = re.match(r'(\d+)-(.+)', folder_name)
    if match:
        num, title = match.groups()
    else:
        num = None
        title = folder_name

    title_spaced = re.sub(r'(?<!^)(?=[A-Z])', ' ', title).strip()
    return num, title_spaced, title.lower()

def main():
    solutions = [f for f in os.listdir('.') if os.path.isdir(f) and f not in IGNORE_DIRS]
    entries = []
    
    for sol in sorted(solutions):
        num, title_spaced, url_title = get_leetcode_number_and_title(sol)
        if not num:
            continue

        link = f'{LEETCODE_URL}{url_title}/'
        entry = f'| {num} | {title_spaced} | [Solution]({sol}) • [Leetcode]({link}) |'
        entries.append(entry)

    with open(README_PATH, 'w', encoding='utf-8') as f:
        f.write('\n'.join(entries))

if __name__ == '__main__':
    main()
