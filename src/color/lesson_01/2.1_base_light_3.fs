#version 330 core
out vec4 FragColor;

in vec3 Normal;  
in vec3 FragPos;  
struct 	Material
{
    vec3 ambient;
    vec3 diffuse;
    vec3 specular;
    float shininess;
};

struct Light
{
    vec3 position;
    vec3 ambient;
    vec3 diffuse;
    vec3 specular;  
};

  
uniform vec3 lightPos; 
uniform vec3 lightColor;
uniform vec3 objectColor;
uniform vec3 viewPos;
uniform Material material;
uniform Light light; 
void main()
{
    // ambient
    float ambientStrength = 0.1;
    vec3 ambient = material.ambient * light.ambient;
  	
    // diffuse 
    vec3 norm = normalize(Normal);
    vec3 lightDir = normalize(lightPos - FragPos);
    float diff = max(dot(norm, lightDir), 0.0);
    vec3 diffuse = (material.diffuse * diff) * light.diffuse;
    
    float specularStrength =  0.5;
    vec3 viewDir = normalize(viewPos - FragPos);
    vec3 reflectDir = reflect(-lightDir, norm);
    float spec = pow(max(dot(viewDir, reflectDir), 0.0), 32);
    vec3 specular = (material.specular * spec) * light.specular;
            
    vec3 result = (ambient + diffuse + specular);
    FragColor = vec4(result, 1.0);
} 
